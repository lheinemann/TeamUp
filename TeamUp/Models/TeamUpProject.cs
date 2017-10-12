using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamUp.Models
{
    public class TeamUpProject
    {
        public string ProjectName { get; set; }
        public string Installer { get; set; }
        public string Originator { get; set; }
        public string ProjectDescription => ProjectName;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string SourceProjectId { get; set; }
    }
}