using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Project.Models
{
    public class Admin
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string Cellphone { get; set; }
        public string Gender { get; set; }
        public bool IsAdmin { get; set; }
        public string AccessId { get; set; }
        public string RoleName { get; set; }

        //public Admin (string firstname, string lastname, string cellphone)
        //{
        //    FirstName = firstname;
        //    LastName = lastname;
        //    Cellphone = cellphone; ;
        //}
    }
}
