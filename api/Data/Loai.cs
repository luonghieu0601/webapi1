using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Data
{
    [Table("Loai")]
    public class Loai
    {
        [Key]
        public int IDLoai { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public virtual ICollection<HangHoa> HangHoas { get; set;}
    }
}
