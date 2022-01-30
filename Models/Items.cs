using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopCRUD.Models
{
    public class Items
    {
        [Key]
        public int ItemId { get; set; }
        
        [Column(TypeName="NVARCHAR(100)")]
        public string ItemName { get; set; }

        [Column(TypeName = "NVARCHAR(100)")]
        public string ItemDescription { get; set; }

        public decimal ItemPrice { get; set; }
    }
}
