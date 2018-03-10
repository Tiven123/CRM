using System;

namespace MvcCRM.Models
{
    public class SupportTicket
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string ReportedBy { get; set; }
        public Client Client { get; set; }
        public string State { get; set; }
    }
}