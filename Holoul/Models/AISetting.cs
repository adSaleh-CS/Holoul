using System.ComponentModel.DataAnnotations;

namespace Holoul.Models
{
    public class AISetting
    {
        [Key]
        public int id { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
    }
}
