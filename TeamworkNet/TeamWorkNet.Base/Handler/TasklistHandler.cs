// ==========================================================
// File: TeamWorkNet.Portable.ProjectHandler.cs
// Created: 14.02.2015
// Created By: Tim cadenbach
// 
// Copyright (C) 2015 Tim Cadenbach
// License: Apache License 2.0
// ==========================================================

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TeamWorkNet.Base;
using TeamWorkNet.Generic;
using TeamWorkNet.Model;
using TeamWorkNet.Response;

namespace TeamWorkNet.Handler
{
  /// <summary>
  /// Handler for Projects
  /// </summary>
  public class TasklistHandler
    {
    private readonly TeamWorkClient _client;

    /// <summary>
    /// Constructor for Project Handler
    /// </summary>
    /// <param name="client">TeamworkClient (Init needed!)</param>
    public TasklistHandler(TeamWorkClient client)
    {
      _client = client;
    }

        /// <summary>
        /// Delete a Task
        /// </summary>
        /// <param name="taskid"></param>
        /// <returns></returns>
        //public async Task<bool> DeleteTask(int taskid)
        //{
        //  using (var client = new AuthorizedHttpClient(_client))
        //  {
        //    var response = await client.DeleteAsync("/tasks/" + taskid + ".json");
        //  }
        //  return false;
        //}

        /// <summary>
        /// Delete a Task
        /// </summary>
        /// <param name="taskid"></param>
        /// <returns></returns>
        //public async Task<bool>CompleteTask(int taskid)
        //{
        //  using (var client = new AuthorizedHttpClient(_client))
        //  {
        //    var response = await client.PutAsync("/tasks/" + taskid + "/complete.json",null);
        //  }
        //  return false;
        //}

        /// <summary>
        /// Delete a Task
        /// </summary>
        /// <param name="taskid"></param>
        /// <returns></returns>
        //public async Task<bool> UnCompleteTask(int taskid)
        //{
        //  using (var client = new AuthorizedHttpClient(_client))
        //  {
        //    var response = await client.PutAsync("/tasks/" + taskid + "/uncomplete.json", null);
        //  }
        //  return false;
        //}



        /// <summary>
        ///   Returns all tags the user has access to
        /// </summary>
        /// <returns></returns>
        
        public async Task<List<string>> GetTaskLists(string projectId)
        {
            using (var client = new AuthorizedHttpClient(_client))
            {
                var data = await client.GetAsync<TaskListResponse2>("/projects/" + projectId + "/tasklists.json", null);
                if (data.StatusCode == HttpStatusCode.OK)
                {
                    var response = (TaskListResponse2)data.ContentObj;
                    return response.TaskLists.Select(t => t.Id).ToList();
                }
                
            }
            return null;
        }



        /// <summary>
        ///   Add a new Tag
        /// </summary>
        /// <returns></returns>
        public async Task<bool> CopyTaskList(string taskListId, int projectId)
        {
          try
          {
            using (var client = new AuthorizedHttpClient(_client))
            {
          
              var settings = new JsonSerializerSettings() { ContractResolver = new NullToEmptyStringResolver() };
              //string post = JsonConvert.SerializeObject(theTag, settings);
              await client.PutAsync("/tasklist/" + taskListId + "/copy.json", new StringContent("{\"projectId\": " + projectId.ToString() + "}", Encoding.UTF8));
              return true;
            }
          }
          catch (Exception)
          {
            return false;
          }
        }

    public async Task CopyTaskList2(int taskListId, int projectId)
    {
        try
        {
            using (var client = new AuthorizedHttpClient(_client))
            {

                var settings = new JsonSerializerSettings() { ContractResolver = new NullToEmptyStringResolver() };
                //string post = JsonConvert.SerializeObject(theTag, settings);
                await client.PutAsync("/tasklist/" + taskListId.ToString() + "/copy.json", new StringContent("{\"projectId\": " + projectId.ToString() + "}", Encoding.UTF8));
            }
        }
        catch (Exception)
        {
        }
    }


    }
}