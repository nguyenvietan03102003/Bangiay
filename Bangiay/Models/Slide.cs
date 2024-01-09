
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bangiay.Models
{
    [Table("Slide")]
    public class Slide
    {
        [Key]
        public long SlideID { get; set; }
        public string? Title { get; set; }
        public string? Abstract { get; set; }
        public string? Contents { get; set; }
        public string? Images { get; set; }
        public string? Link { get; set; }
        public string? Author { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsActive { get; set; }
        public int SlideOrder { get; set; }
        public int Status { get; set; }
    }
}
