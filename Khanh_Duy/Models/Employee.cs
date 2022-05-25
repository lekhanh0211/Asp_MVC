using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Khanh_Duy.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string Phone { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public bool Gender { get; set; }


    }
}