using Jira_Cherwell_Integration_POC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Jira_Cherwell_Integration.Handlers
{
    public class RequestHandler
    {
        private string request;
        private string connection;

        public RequestHandler(string Request, string conn)
        {
            request = Request;
            connection = conn;
        }

        public async Task<bool> HandleJiraIncomingRequestsAsync()
        {
            try
            {
                var jsonModel = JsonConvert.DeserializeObject<JiraIncomingRequestModel>(request);

                //only focused on creation for this POC
                if (jsonModel != null && jsonModel.webhookEvent == "jira:issue_created")
                {
                    var jiraRequestModel = new JiraRequestModel(jsonModel.issue.fields.project.name,
                    jsonModel.issue.key,
                    jsonModel.issue.fields.summary,
                    jsonModel.issue.fields.description,
                    jsonModel.webhookEvent,
                    jsonModel.user.emailAddress);

                    var cherwellPostModel = MapJiraRequestIntoCherwellPost(jiraRequestModel);

                    using (var client = new HttpClient())
                    {
                        //hardcoded test Cherwell 
                        //check with Christian Viray 
                        var httpResponseMessage = await client.PostAsync(connection, new StringContent(JsonConvert.SerializeObject(cherwellPostModel), Encoding.UTF8, "application/json"));
                        if(httpResponseMessage.StatusCode == System.Net.HttpStatusCode.OK) 
                        {
                            return true;
                        }

                        return false;
                    }

                }

                return false;

            }
            catch (Exception ex)
            {
                //TODO : Add some error logging here.
                return false;
            }
        }


        public CherwellPostModel MapJiraRequestIntoCherwellPost (JiraRequestModel jiraModel)
        {

            //Please work with Christian Viray for the cherwell integration and Searching.
            //this needs a lot of work.
            var cherwellModel = new CherwellPostModel();

            cherwellModel.JiraTicketNum = jiraModel.IssueNumber;
            cherwellModel.UserEmail = jiraModel.JiraEmailAddress;

            var cherwellTasks = new List<Jira_Cherwell_Integration_POC.Models.Task>();

            //Hard coded some Cherwell values here this should be updated...
            var cherwellTask = new Jira_Cherwell_Integration_POC.Models.Task();
            cherwellTask.TeamName = "IT Service Management";
            cherwellTask.Subject = jiraModel.Summary;
            cherwellTask.Notes = jiraModel.Description;
            cherwellTask.TaskOwnerName = "Christian Viray";

            cherwellTasks.Add(cherwellTask);

            cherwellModel.UserEmail = jiraModel.JiraEmailAddress;
            cherwellModel.Tasks = cherwellTasks;


            return cherwellModel;
        }

    }

}
