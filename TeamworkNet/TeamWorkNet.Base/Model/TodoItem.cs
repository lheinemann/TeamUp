﻿// ==========================================================
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
  public class TodoItem
  {
    [JsonProperty("project-id", NullValueHandling = NullValueHandling.Ignore)]
    public int ProjectId { get; set; }

    [JsonProperty("completer_lastname", NullValueHandling = NullValueHandling.Ignore)]
    public string CompleterLastname { get; set; }

    [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
    public string Order { get; set; }

    [JsonProperty("comments-count", NullValueHandling = NullValueHandling.Ignore)]
    public string CommentsCount { get; set; }

    [JsonProperty("created-on", NullValueHandling = NullValueHandling.Ignore)]
    private string createdOn { get; set; }

    [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
    public Tag[] Tags { get; set; }


    [JsonProperty("notify", NullValueHandling = NullValueHandling.Ignore)]
    public bool notify { get; set; }

    public DateTime CreatedOn
    {
      get { return createdOn.ToDateTimeExactMin(); }
    }

    [JsonProperty("canEdit", NullValueHandling = NullValueHandling.Ignore)]
    public bool CanEdit { get; set; }

    [JsonProperty("has-predecessors", NullValueHandling = NullValueHandling.Ignore)]
    public string HasPredecessors { get; set; }

    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string id { get; set; }

    [JsonProperty("completed", NullValueHandling = NullValueHandling.Ignore)]
    public bool Completed { get; set; }

    [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
    public string Position { get; set; }

    [JsonProperty("estimated-minutes", NullValueHandling = NullValueHandling.Ignore)]
    public int EstimatedMinutes { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
    public int Progress { get; set; }

    [JsonProperty("harvest-enabled", NullValueHandling = NullValueHandling.Ignore)]
    public bool HarvestEnabled { get; set; }

    [JsonProperty("parentTaskId", NullValueHandling = NullValueHandling.Ignore)]
    public int ParentTaskId { get; set; }

    [JsonProperty("responsible-party-lastname", NullValueHandling = NullValueHandling.Ignore)]
    public string ResponsiblePartyLastname { get; set; }

    [JsonProperty("company-id", NullValueHandling = NullValueHandling.Ignore)]
    public string CompanyId { get; set; }

    [JsonProperty("creator-avatar-url", NullValueHandling = NullValueHandling.Ignore)]
    public string CreatorAvatarUrl { get; set; }

    [JsonProperty("creator-id", NullValueHandling = NullValueHandling.Ignore)]
    public string CreatorId { get; set; }

    [JsonProperty("project-name", NullValueHandling = NullValueHandling.Ignore)]
    public string ProjectName { get; set; }

    [JsonProperty("start-date", NullValueHandling = NullValueHandling.Ignore)]
    public string startDate { get; set; }

    [JsonIgnore]
    public DateTime StartDate
    {
      get { return string.IsNullOrEmpty(startDate) ? DateTime.MinValue : startDate.ToDateTimeExactMin(); }
      set { startDate = value.ToString("yyyyMMdd"); }
    }

    [JsonProperty("tasklist-private", NullValueHandling = NullValueHandling.Ignore)]
    public string TasklistPrivate { get; set; }

    [JsonProperty("lockdownId", NullValueHandling = NullValueHandling.Ignore)]
    public string LockdownId { get; set; }

    [JsonProperty("canComplete", NullValueHandling = NullValueHandling.Ignore)]
    public bool CanComplete { get; set; }

    [JsonProperty("responsible-party-id", NullValueHandling = NullValueHandling.Ignore)]
    public int ResponsiblePartyId { get; set; }

    [JsonProperty("creator-lastname", NullValueHandling = NullValueHandling.Ignore)]
    public string CreatorLastname { get; set; }

    [JsonProperty("has-reminders", NullValueHandling = NullValueHandling.Ignore)]
    public bool HasReminders { get; set; }

    [JsonProperty("todo-list-name", NullValueHandling = NullValueHandling.Ignore)]
    public string TodoListName { get; set; }

    [JsonProperty("has-unread-comments", NullValueHandling = NullValueHandling.Ignore)]
    public bool HasUnreadComments { get; set; }

    [JsonProperty("due-date-base", NullValueHandling = NullValueHandling.Ignore)]
    public string dueDateBase;

    public DateTime DueDateBase
    {
      get { return dueDateBase.ToDateTimeExactMax(); }
      set { dueDateBase = value.ToString("yyyyMMdd"); }
    }

    [JsonProperty("private", NullValueHandling = NullValueHandling.Ignore)]
    public string Private { get; set; }

    [JsonProperty("responsible-party-summary", NullValueHandling = NullValueHandling.Ignore)]
    public string ResponsiblePartySummary { get; set; }

    [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
    public string Status { get; set; }

    [JsonProperty("todo-list-id", NullValueHandling = NullValueHandling.Ignore)]
    public int TodoListId { get; set; }

    [JsonProperty("predecessors", NullValueHandling = NullValueHandling.Ignore)]
    public object[] Predecessors { get; set; }

    [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
    public string Content { get; set; }

    [JsonProperty("responsible-party-type", NullValueHandling = NullValueHandling.Ignore)]
    public string ResponsiblePartyType { get; set; }

    [JsonProperty("company-name", NullValueHandling = NullValueHandling.Ignore)]
    public string CompanyName { get; set; }

    [JsonProperty("creator-firstname", NullValueHandling = NullValueHandling.Ignore)]
    public string CreatorFirstname { get; set; }

    [JsonProperty("last-changed-on", NullValueHandling = NullValueHandling.Ignore)]
    public string lastChangedOn;

    [JsonIgnore]
    public DateTime LastChangedOn
    {
      get { return DateTime.Parse(lastChangedOn); }
    }

    [JsonProperty("due-date", NullValueHandling = NullValueHandling.Ignore)]
    public string dueDate;
                  [JsonIgnore]
    public DateTime DueDate
    {
      get { return string.IsNullOrEmpty(dueDate) ? DateTime.MinValue : dueDate.ToDateTimeExactMax(); }
      set { dueDate = value.ToString("yyyyMMdd"); }
    }

    [JsonProperty("completed_on", NullValueHandling = NullValueHandling.Ignore)]
    public string completedOn;
    public DateTime CompletedOn
    {
      get { return completedOn.ToDateTimeExactMax(); }
      set { completedOn = value.ToString("yyyyMMdd"); }
    }

    [JsonProperty("has-dependencies", NullValueHandling = NullValueHandling.Ignore)]
    public string HasDependencies { get; set; }

    [JsonProperty("attachments-count", NullValueHandling = NullValueHandling.Ignore)]
    public string AttachmentsCount { get; set; }

    [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
    public string Priority { get; set; }

    [JsonProperty("completer_id", NullValueHandling = NullValueHandling.Ignore)]
    public string CompleterId { get; set; }

    [JsonProperty("responsible-party-firstname", NullValueHandling = NullValueHandling.Ignore)]
    public string ResponsiblePartyFirstname { get; set; }

    [JsonProperty("viewEstimatedTime", NullValueHandling = NullValueHandling.Ignore)]
    public bool ViewEstimatedTime { get; set; }

    [JsonProperty("responsible-party-ids", NullValueHandling = NullValueHandling.Ignore)]
    public string ResponsiblePartyIds { get; set; }

    [JsonProperty("responsible-party-names", NullValueHandling = NullValueHandling.Ignore)]
    public string ResponsiblePartyNames { get; set; }

    [JsonProperty("completer_firstname", NullValueHandling = NullValueHandling.Ignore)]
    public string CompleterFirstname { get; set; }

    [JsonProperty("tasklist-lockdownId", NullValueHandling = NullValueHandling.Ignore)]
    public string TasklistLockdownId { get; set; }

    [JsonProperty("canLogTime", NullValueHandling = NullValueHandling.Ignore)]
    public bool CanLogTime { get; set; }

    [JsonProperty("timeIsLogged", NullValueHandling = NullValueHandling.Ignore)]
    public string TimeIsLogged { get; set; }

    [JsonProperty("sub-tasks", NullValueHandling = NullValueHandling.Ignore)]
    public List<TodoItem> SubTasks { get; set; }

    [JsonIgnore]
    public int TotalDays => new TimeSpan(DueDate.Ticks - StartDate.Ticks).Days + 1;
    [JsonIgnore]
    public int DaysProgressed => new TimeSpan(DateTime.Now.Ticks - StartDate.Ticks).Days;
    [JsonIgnore]
    public double ProgressExpected => DaysProgressed / TotalDays;


  }
}