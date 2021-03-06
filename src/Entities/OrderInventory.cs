using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("OrderInventory")]
    public class OrderInventory
    {
        [Key]
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int InventoryId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(256)]
        public string ProductName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(256)]
        public string Specification { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        [ForeignKey(nameof(OrderId))]
        public virtual Order Order { get; set; }

        [ForeignKey(nameof(InventoryId))]
        public virtual Inventory Inventory { get; set; }
    }
}