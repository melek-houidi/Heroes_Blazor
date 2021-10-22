using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Data
{
    public class Student
    {   
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentAge { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
    }
}
