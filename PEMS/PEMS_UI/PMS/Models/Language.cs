using System.ComponentModel.DataAnnotations;

namespace PEMS_UI.Models
{
    public class Language
    {
        [Key]
        public int LangId { get; set; }
        public string  LanguageName { get; set; }

    }
}
