namespace Jira_Cherwell_Integration_POC.Models
{
    public class JiraRequestModel
    {
        //Name of the JIRA Project Dashboard.
        public string ProjectName { get; set; }

        public string IssueNumber { get; set; }

        public string Summary { get; set; }

        public string Description { get; set; }

        public string JiraEmailAddress { get; set; }

        public enum JiraEventType
        {
            Create,
            Update,
            Delete,
            WorklogUpdated,
            None
        }

        public JiraEventType JiraEvent { get; set; }

    public JiraRequestModel(){ }

        public JiraRequestModel(string projectName, string issueNumber, string summary, string description, string jiraEventDescription, string userEmail)
        {
            ProjectName = projectName;
            IssueNumber = issueNumber;
            Summary = summary;
            Description = description;
            JiraEmailAddress = userEmail;

            JiraEvent = jiraEventDescription switch
            {
                "jira:issue_created" => JiraEventType.Create,
                "jira:issue_updated" => JiraEventType.Update,
                "jira:issue_deleted" => JiraEventType.Delete,
                "jira:worklog_updated" => JiraEventType.WorklogUpdated,
                _ => JiraEventType.None,
            };
        }

    }
}
