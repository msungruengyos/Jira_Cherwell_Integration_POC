using System;
using System.Collections.Generic;

namespace Jira_Cherwell_Integration_POC.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class AvatarUrls
    {
        public string _48x48 { get; set; }
        public string _24x24 { get; set; }
        public string _16x16 { get; set; }
        public string _32x32 { get; set; }
    }

    public class User
    {
        public string self { get; set; }
        public string accountId { get; set; }
        public string emailAddress { get; set; }
        public AvatarUrls avatarUrls { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
        public string timeZone { get; set; }
        public string accountType { get; set; }
    }

    public class Issuetype
    {
        public string self { get; set; }
        public string id { get; set; }
        public string description { get; set; }
        public string iconUrl { get; set; }
        public string name { get; set; }
        public bool subtask { get; set; }
        public int avatarId { get; set; }
        public int hierarchyLevel { get; set; }
    }

    public class Project
    {
        public string self { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string projectTypeKey { get; set; }
        public bool simplified { get; set; }
        public AvatarUrls avatarUrls { get; set; }
    }

    public class Watches
    {
        public string self { get; set; }
        public int watchCount { get; set; }
        public bool isWatching { get; set; }
    }

    public class Issuerestrictions
    {
    }

    public class Issuerestriction
    {
        public Issuerestrictions issuerestrictions { get; set; }
        public bool shouldDisplay { get; set; }
    }

    public class Priority
    {
        public string self { get; set; }
        public string iconUrl { get; set; }
        public string name { get; set; }
        public string id { get; set; }
    }

    public class NonEditableReason
    {
        public string reason { get; set; }
        public string message { get; set; }
    }

    public class Customfield10018
    {
        public bool hasEpicLinkFieldDependency { get; set; }
        public bool showField { get; set; }
        public NonEditableReason nonEditableReason { get; set; }
    }

    public class StatusCategory
    {
        public string self { get; set; }
        public int id { get; set; }
        public string key { get; set; }
        public string colorName { get; set; }
        public string name { get; set; }
    }

    public class Status
    {
        public string self { get; set; }
        public string description { get; set; }
        public string iconUrl { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public StatusCategory statusCategory { get; set; }
    }

    public class Timetracking
    {
    }

    public class Creator
    {
        public string self { get; set; }
        public string accountId { get; set; }
        public string emailAddress { get; set; }
        public AvatarUrls avatarUrls { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
        public string timeZone { get; set; }
        public string accountType { get; set; }
    }

    public class Reporter
    {
        public string self { get; set; }
        public string accountId { get; set; }
        public string emailAddress { get; set; }
        public AvatarUrls avatarUrls { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
        public string timeZone { get; set; }
        public string accountType { get; set; }
    }

    public class Aggregateprogress
    {
        public int progress { get; set; }
        public int total { get; set; }
    }

    public class Progress
    {
        public int progress { get; set; }
        public int total { get; set; }
    }

    public class Votes
    {
        public string self { get; set; }
        public int votes { get; set; }
        public bool hasVoted { get; set; }
    }

    public class Fields
    {
        public DateTime statuscategorychangedate { get; set; }
        public Issuetype issuetype { get; set; }
        public object timespent { get; set; }
        public Project project { get; set; }
        public List<object> fixVersions { get; set; }
        public object aggregatetimespent { get; set; }
        public object resolution { get; set; }
        public object customfield_10027 { get; set; }
        public object customfield_10028 { get; set; }
        public object resolutiondate { get; set; }
        public int workratio { get; set; }
        public object lastViewed { get; set; }
        public Watches watches { get; set; }
        public Issuerestriction issuerestriction { get; set; }
        public DateTime created { get; set; }
        public object customfield_10020 { get; set; }
        public object customfield_10021 { get; set; }
        public object customfield_10022 { get; set; }
        public Priority priority { get; set; }
        public object customfield_10023 { get; set; }
        public List<object> labels { get; set; }
        public object customfield_10016 { get; set; }
        public object customfield_10017 { get; set; }
        public Customfield10018 customfield_10018 { get; set; }
        public string customfield_10019 { get; set; }
        public object timeestimate { get; set; }
        public object aggregatetimeoriginalestimate { get; set; }
        public List<object> versions { get; set; }
        public List<object> issuelinks { get; set; }
        public object assignee { get; set; }
        public DateTime updated { get; set; }
        public Status status { get; set; }
        public List<object> components { get; set; }
        public object timeoriginalestimate { get; set; }
        public string description { get; set; }
        public object customfield_10010 { get; set; }
        public object customfield_10014 { get; set; }
        public Timetracking timetracking { get; set; }
        public object customfield_10015 { get; set; }
        public object customfield_10005 { get; set; }
        public object customfield_10006 { get; set; }
        public object customfield_10007 { get; set; }
        public object security { get; set; }
        public object customfield_10008 { get; set; }
        public List<object> attachment { get; set; }
        public object aggregatetimeestimate { get; set; }
        public object customfield_10009 { get; set; }
        public string summary { get; set; }
        public Creator creator { get; set; }
        public List<object> subtasks { get; set; }
        public Reporter reporter { get; set; }
        public Aggregateprogress aggregateprogress { get; set; }
        public string customfield_10000 { get; set; }
        public object customfield_10001 { get; set; }
        public object customfield_10002 { get; set; }
        public object customfield_10003 { get; set; }
        public object customfield_10004 { get; set; }
        public object environment { get; set; }
        public object duedate { get; set; }
        public Progress progress { get; set; }
        public Votes votes { get; set; }
    }

    public class Issue
    {
        public string id { get; set; }
        public string self { get; set; }
        public string key { get; set; }
        public Fields fields { get; set; }
    }

    public class Item
    {
        public string field { get; set; }
        public string fieldtype { get; set; }
        public string fieldId { get; set; }
        public object from { get; set; }
        public object fromString { get; set; }
        public string to { get; set; }
        public string toString { get; set; }
        public object tmpFromAccountId { get; set; }
        public string tmpToAccountId { get; set; }
    }

    public class Changelog
    {
        public string id { get; set; }
        public List<Item> items { get; set; }
    }

    public class JiraIncomingRequestModel
    {
        public long timestamp { get; set; }
        public string webhookEvent { get; set; }
        public string issue_event_type_name { get; set; }
        public User user { get; set; }
        public Issue issue { get; set; }
        public Changelog changelog { get; set; }
    }
}

   


