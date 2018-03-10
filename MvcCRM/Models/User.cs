using System;

namespace MvcCRM.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string role { get; set; }
    }
}