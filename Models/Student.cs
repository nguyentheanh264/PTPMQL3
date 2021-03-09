using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL3.Models
{
    [Table("Students")]
    public class Student
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public int  Age { get; set; }
    }
}