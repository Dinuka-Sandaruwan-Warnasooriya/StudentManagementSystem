using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        public String FName { get; set; }

        [DisplayName("Last Name")]
        public String LNaame { get; set; }

        public String City { get; set; }
        public DateTime Birthday { get; set; }

        
    }
}
