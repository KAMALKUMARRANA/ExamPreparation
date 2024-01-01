using System.ComponentModel.DataAnnotations;

namespace PEMS_UI.Models.DTOs
{
    public class AddEmployeeForm
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Required]
        public EmployeeType Type { get; set; }

        [Required]
        public Position Position { get; set; }

        [Required]
        public string ImgUrl { get; set; }

        public string? Gender { get; set; }

        public string? Description { get; set; }

        public int? LangId { get; set; }
        public string? Language { get; set; }

        public string Email { get; set; }
        public bool TC { get; set; }

        public List<string> SelectedLanguageId { get; set; }

    }
}
