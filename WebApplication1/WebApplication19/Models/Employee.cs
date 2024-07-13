using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication19.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is mandotry")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Email is Mandatory")]
        [RegularExpression(@"//A(?:[a-z0-9!#$%&'*+/=?^_{|}~-]+(?://.[a-z0-9!#$%&'*+/=?^_{|}~-]+)@(?:[a-z0-9](?:[a-z0-9-][a-z0-9])?//.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)//Z/",ErrorMessage="please enter correct email address")]
        public string Email { get; set; }
        [MinLength(4,ErrorMessage ="userName must be more than 4 characters")]
        [MaxLength(10,ErrorMessage = "userName must be less than 10 characters")]
        public string UserName { get; set; }
    }
}