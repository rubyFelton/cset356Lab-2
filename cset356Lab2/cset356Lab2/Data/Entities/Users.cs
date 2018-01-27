using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace cset356Lab2.Data.Entities
{
    public class Users
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public String firstName { get; set; }
        [Display(Name = "Middle Name")]
        public String middleName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public String lastName { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        public String email { get; set; }
        [Required]
        [Display(Name = "Years In School")]
        public int yearsInSchool { get; set; }


    }
}