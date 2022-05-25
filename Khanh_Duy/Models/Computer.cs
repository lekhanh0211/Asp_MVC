using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Khanh_Duy.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime yearMaking { get; set; }
        public string Producer { get; set; }

      
    }
}