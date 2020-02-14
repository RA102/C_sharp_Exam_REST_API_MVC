using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class TimingTrainingDetailDto
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string  FIO { get; set; }
        public string TypeName { get; set; }
        public int Quantity { get; set; }
    }
}