using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarSpecials.Data.Models
{
    [Table("Places")]
    public class PlaceModel
    {
        [Key]
        [StringLength(32)]
        [Column(TypeName = "char")]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
