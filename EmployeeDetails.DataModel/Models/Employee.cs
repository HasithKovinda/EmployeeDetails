using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails.DataModel.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        [Range(18, 30,
            ErrorMessage = "Age must be between 18 and 30")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Address Number is required.")]
        public string Address { get; set; }

        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "Phone Number is required.")]
        public long PhoneNumber { get; set; }
    }
}
