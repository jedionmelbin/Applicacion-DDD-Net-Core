using System.ComponentModel.DataAnnotations;

namespace LearningSchool.Transport
{
    public class CourseDTO
    {
      
        public int CourseID { get; set; }

        [Required(ErrorMessage = "Please enter field name")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter field name")]
        public int Credits { get; set; }
    }
}