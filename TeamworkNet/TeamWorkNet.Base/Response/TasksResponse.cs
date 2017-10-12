﻿// ==========================================================
// File: TeamWorkNet.Base.TasksResponse.cs
// Created: 14.02.2015
// Created By: Tim cadenbach
// 
// Copyright (C) 2015 Tim Cadenbach
// License: Apache License 2.0
// ==========================================================

using Newtonsoft.Json;
using  TeamWorkNet.Model;

namespace TeamWorkNet.Response
{
  public class TasksResponse
  {
    [JsonProperty("todo-items")]
    public TodoItem[] TodoItems { get; set; }

    [JsonProperty("STATUS")]
    public string STATUS { get; set; }
  }

  public class TaskResponse
  {
    [JsonProperty("todo-item")]
    public TodoItem TodoItem { get; set; }

    [JsonProperty("STATUS")]
    public string STATUS { get; set; }
  }

}