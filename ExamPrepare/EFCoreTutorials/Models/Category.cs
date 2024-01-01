using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreTutorials.Models
{
    public class Category
    {
        public Guid Id { get; set; }
       
        public string? Name { get; set; }
    }
}
