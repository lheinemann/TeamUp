// ==========================================================
// File: TeamWorkNet.Base.TodoItem.cs
// Created: 14.02.2015
// Created By: Tim cadenbach
// 
// Copyright (C) 2015 Tim Cadenbach
// License: Apache License 2.0
// ==========================================================

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using TeamWorkNet.Base.Model;
using TeamWorkNet.Extensions.DateTime;

namespace TeamWorkNet.Model
{
  public class Tasklist
    {

    [JsonProperty("projectid", NullValueHandling = NullValueHandling.Ignore)]
    public string ProjectId { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }



    //    [JsonProperty("sub-tasks", NullValueHandling = NullValueHandling.Ignore)]
    //public List<TodoItem> SubTasks { get; set; }


  }
}