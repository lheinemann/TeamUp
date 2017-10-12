// ==========================================================
// File: TeamWorkNet.Base.TasksResponse.cs
// Created: 14.02.2015
// Created By: Tim cadenbach
// 
// Copyright (C) 2015 Tim Cadenbach
// License: Apache License 2.0
// ==========================================================

using System.Collections.Generic;
using Newtonsoft.Json;
using  TeamWorkNet.Model;

namespace TeamWorkNet.Response
{
  public class TaskListResponse2
    {
    [JsonProperty("tasklists")]
    public List<Tasklist> TaskLists { get; set; }

    [JsonProperty("STATUS")]
    public string STATUS { get; set; }
  }

 

}