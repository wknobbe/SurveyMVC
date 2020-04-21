using System.ComponentModel.DataAnnotations;

namespace SurveyMVC.Models
{
    public class Survey
    {
        [Required(ErrorMessage="Name is required.")]
        [MinLength(2, ErrorMessage="Name must be at least 2 characters long.")]
        [Display(Name=" Your Name:")]
        public string Name {get; set;}
        [Required(ErrorMessage="Location is required.")]
        [Display(Name="Dojo Location:")]
        public string Location {get; set;}
        [Required(ErrorMessage="Language is required.")]
        [Display(Name="Favorite Language:")]
        public string Language {get; set;}
        [MaxLength(20)]
        [Display(Name="Comment (optional):")]
        public string Comment {get; set;}
    }
}