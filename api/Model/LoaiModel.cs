using System.ComponentModel.DataAnnotations;

namespace api.Model
{
    public class LoaiModel
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
