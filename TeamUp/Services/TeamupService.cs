using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TeamUp.Models;
using TeamWorkNet.Base;
using TeamWorkNet.Handler;
using TeamWorkNet.Model;

namespace TeamUp.Services
{
    public class TeamupService
    {
        private TeamWorkClient _client;
        private const string CategoryId = "32484";
        private const string DefaultSourceProjectId = "317143";

        public TeamupService(string apiKey = "twp_CRU1fHdwvOVkH9EN1zSWsEHB8kbP", string domain = "https://solaruniverse.teamwork.com")
        {
            _client = new TeamWorkClient();
            _client.Init(apiKey, domain);
        }

        public IEnumerable<Models.TeamUpProject> GetProjects()
        {
            var handler = new ProjectHandler(_client);
            var projects = handler.GetAllProjects();

            return projects?.projects.Select(p => new Models.TeamUpProject() { ProjectName = p.name });
        }

        public async Task<int> CreateProjectAsync(TeamUpProject project)
        {
            int projectId = 0;

            var projectHandler = new ProjectHandler(_client);
            Newproject newProject = new Newproject()
            {
                Name = project.ProjectName,
                Description = project.ProjectDescription,
                StartDate = project.StartDate.ToString("yyyyMMdd"),
                EndDate = project.EndDate.ToString("yyyyMMdd"),
                CategoryId = CategoryId,
                UseBilling = "1",
                UseFiles = "1",
                UseLinks = "1",
                UseMessages = "1",
                UseMilestones = "1",
                UseNotebook = "1",
                UseRiskregister = "1",
                UseTasks = "1",
                UseTime = "1"
            };

            //Add project
            var result = await projectHandler.AddProject(newProject);

            if(result != null && result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                projectId = (int)result.ContentObj;
                var taskListHandler = new TasklistHandler(_client);

                string sourceProjectId = string.IsNullOrEmpty(project.SourceProjectId) ? DefaultSourceProjectId : project.SourceProjectId;

                //get tasklist based on reference project
                List<string> TaskLists = await taskListHandler.GetTaskLists(sourceProjectId);
                
                if(TaskLists != null && TaskLists.Count >0)
                {
                    //copy taskLists to project
                    List<Task> taskStack = new List<Task>();
                    TaskLists.ForEach(t =>
                    {
                        taskStack.Add(taskListHandler.CopyTaskList(t, projectId));
                    });

                    await Task.WhenAll(taskStack.ToArray());
                }

            }

            return projectId;
        }

    }
}