using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Crud_app.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage= "First Name is required.")]
        [MaxLength(10, ErrorMessage ="first name should contain maximum fifty characters.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(10, ErrorMessage = "first name should contain maximum fifty characters.")]
        public string LastName { get; set; }
   
        public string MobileNumber { get; set; }
        [DataType(DataType.EmailAddress)] 
        public string Email { get; set; }
        public string AdressLine1 { get; set; }
        public string AdressLine2 { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
    }
}
