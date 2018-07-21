using System;
using System.ComponentModel.DataAnnotations;

namespace LearningSchool.Transport
{
    public class StudentDTO
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter field last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter field fist name name")]
        public string FirstMidName { get; set; }

        [Required]
        public DateTime EnrollmentDate { get; set; }
    }
}
