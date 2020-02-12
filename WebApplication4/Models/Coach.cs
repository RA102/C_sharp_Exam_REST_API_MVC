using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Coach
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public string Specialization { get; set; }
        public DateTime WorkTIme { get; set; }
    }
}