using System;

namespace MvcCRM.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public Client Client { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string email { get; set; }
        public int CelphoneNumber { get; set; }
        public string Position { get; set; }
    }
}