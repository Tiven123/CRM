using System;

namespace MvcCRM.Models
{
    public class Meeting
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
        public Boolean IsVirtual { get; set; }
        public Client Client { get; set; }
    }
}