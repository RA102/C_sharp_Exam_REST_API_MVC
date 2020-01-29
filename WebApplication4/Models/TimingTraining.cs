using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class TimingTraining
    {
        public int Id { get; set; }
        public int GymId { get; set; }
        public Gym Gym { get; set; }
        public int CoachId { get; set; }
        public Coach Coach { get; set; }
        public int TypeId { get; set; }
        public TypeTraining Type { get; set; }
        public int Quantity { get; set; }
    }
}