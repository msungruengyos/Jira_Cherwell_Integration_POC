using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using Jira_Cherwell_Integration.Handlers;
using Microsoft.Extensions.Configuration;

namespace Jira_Cherwell_Integration.Controllers
{
    [ApiController]
    [Route("/api/[controller]/[action]")]
    public class JiraController : ControllerBase
    {
        private readonly string connection;
        public JiraController(IConfiguration config)
        {
            connection = config.GetConnectionString("DEV");
        }

        [HttpGet]
        public void Get()
        {
            //use this to test... it will use the local jira json file
            try
            {
                using (var reader = new StreamReader("JiraTicketCreateExample.json"))
                {
                    var body = reader.ReadToEnd();

                    if (!string.IsNullOrWhiteSpace(body))
                    {
                        var sent = new RequestHandler(body,connection).HandleJiraIncomingRequestsAsync();
                    }

                }
            }
            catch (Exception ex)
            {
                // TODO: add some sort of error logging in the future;
            }
        }

        [HttpPost]
        public void Post()
        {
            try
            {
                using (var reader = new StreamReader(Request.Body))
                {
                    var body = reader.ReadToEnd();

                    if (!string.IsNullOrWhiteSpace(body))
                    {
                        var sent = new RequestHandler(body,connection).HandleJiraIncomingRequestsAsync();
                    }

                }
            }
            catch(Exception ex)
            {
               // TODO: add some sort of error logging in the future;
            }

        }

    }
}
