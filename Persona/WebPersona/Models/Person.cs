using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebPersona.Models
{
        public enum SexType
        {
            Female = 0,
            Male = 1
        }

        public class Person
        {
            [Key]
            public int PersonID { get; set; }
            [Required]
            [StringLength(250, MinimumLength = 5, ErrorMessage = "Please enter a name from 5 to 50 characters lenght")]
            public string Name { get; set; }
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime BirthDate { get; set; }
            public SexType Sex { get; set; }


        }
    
}