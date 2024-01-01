using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace PEMS_UI.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public decimal Salary { get; set; }
        public EmployeeType Type { get; set; }
        public Position Position { get; set; }
        public string? Gender { get; set; }

        public string? Description { get; set; }

        public string Email { get; set; }
        public bool TC { get; set; }
        public int? LangId { get; set; }
        public string? Language { get; set; }

    


    }

    public enum EmployeeType
    {
        [Display(Name ="Freelance")] Freelance,
        [Display(Name = "Casual")] Casual,
        [Display(Name = "Part Time")] PartTime,
        [Display(Name = "Full Time")] FullTime

    }
    public enum Gender
    {
        [Display(Name = "Male")] Male,
        [Display(Name = "Female")] Female,
        [Display(Name = "Others")] Others,
      

    }
    public enum Position
    {
        [Display(Name = "CEO")] CEO,
        [Display(Name = "CFO")] CFO,
        [Display(Name = "CTO")] CTO,
        [Display(Name = "Accountant")] Accountant,
        [Display(Name = "HR Manager")] HRManager,
        [Display(Name = "Marketing Manager")] MarketingManager,
        [Display(Name = "IT Admin")] ITAdmin,   
       

    }
    
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
              .GetMember(enumValue.ToString())
              .First()
              .GetCustomAttribute<DisplayAttribute>()
              ?.GetName();
        }
    }
}
