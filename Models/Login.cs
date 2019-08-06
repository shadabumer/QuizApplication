using System.ComponentModel.DataAnnotations;  

namespace  QuizApplication.Models {
    public class Login {
        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}