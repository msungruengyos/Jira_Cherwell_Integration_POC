using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jira_Cherwell_Integration_POC.Models
{
    //This model will change overtime please work with Cherwell Developer to update this...
    public class CherwellPostModel
    {
        public string Service { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public string ClientID { get; set; }
        public string Description { get; set; }
        public string JiraTicketNum { get; set; }
        public string UserEmail { get; set; }
        public List<Task> Tasks { get; set; }
    }

    public class Task
    {
        public string TeamName { get; set; }
        public string Subject { get; set; }
        public string Notes { get; set; }
        public string TaskOwnerName { get; set; }
    }
}
