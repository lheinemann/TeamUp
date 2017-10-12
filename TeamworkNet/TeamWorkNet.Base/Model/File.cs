﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TeamWorkNet.Model
{


  public class TeamworkFileVersion
  {
    public string pendingFileRef { get; set; }
    public string description { get; set; }
  }

    public class TeamWorkFile
    {

      [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
      public string Name { get; set; }

      [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
      public string Description { get; set; }

      [JsonProperty("category-id", NullValueHandling = NullValueHandling.Ignore)]
      public string CategoryId { get; set; }

    [JsonProperty("category-name", NullValueHandling = NullValueHandling.Ignore)]
    public string CategoryName { get; set; }

    [JsonProperty("project-id", NullValueHandling = NullValueHandling.Ignore)]
    public string projectid { get; set; }

    [JsonProperty("uploaded-by-user-last-name", NullValueHandling = NullValueHandling.Ignore)]
    public string uploadedbyuserlastname { get; set; }
    [JsonProperty("uploaded-by-user-first-name", NullValueHandling = NullValueHandling.Ignore)]
    public string uploadedbyuserfirstname { get; set; }

    [JsonProperty("uploaded-date", NullValueHandling = NullValueHandling.Ignore)]
    public string Uploaded { get; set; }

    [JsonProperty("uploaded-by-userId", NullValueHandling = NullValueHandling.Ignore)]
    public string UploadedBy  { get; set; }

    [JsonProperty("comments-count", NullValueHandling = NullValueHandling.Ignore)]
    public string CommentCount { get; set; }

    [JsonProperty("version-id", NullValueHandling = NullValueHandling.Ignore)]
    public string versionid { get; set; }

    [JsonProperty("private", NullValueHandling = NullValueHandling.Ignore)]
    public string Isprivate { get; set; }

    [JsonProperty("download-URL", NullValueHandling = NullValueHandling.Ignore)]
    public string URL { get; set; }

    [JsonProperty("project-name", NullValueHandling = NullValueHandling.Ignore)]
    public string projectname { get; set; }

    public string version { get; set; }
    public string originalName { get; set; }
    public string id { get; set; }
    public string size { get; set; }

    [JsonProperty("file-source", NullValueHandling = NullValueHandling.Ignore)]
    public string filesource { get; set; }

    [JsonProperty("pendingFileRef", NullValueHandling = NullValueHandling.Ignore)]
    public string PendingFileRef { get; set; }
    }




   

}
