using System;
using System.ComponentModel.DataAnnotations;

namespace MvcCRM.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [Display(Name = "Legal Document")]
        public string LegalDocument { get; set; }
        [Display(Name = "WEb Site")]
        public string WebSite { get; set; }
        public string Adress { get; set; }
        [Display(Name = "Celphone Number")]
        public int CelphoneNumber { get; set; }
        public string Sector { get; set; }
    }
}