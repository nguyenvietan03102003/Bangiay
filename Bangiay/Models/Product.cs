using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bangiay.Models
{
    [Table("Production")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? Abstract { get; set; }
        public string? Contents { get; set; }
        public string? Images { get; set; }
        public string? Link { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsActive { get; set; }
        public int ProductOrder { get; set; }
        public int MenuID { get; set; }
        public string? Color { get; set; }
        public decimal? Price { get; set; }

    }
}
