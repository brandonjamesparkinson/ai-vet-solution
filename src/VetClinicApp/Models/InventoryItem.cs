using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetClinicApp.Models
{
    public class InventoryItem
    {
        [Key]
        public int InventoryItemId { get; set; }

        [Required]
        [StringLength(50)]
        public string ItemCode { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        
        public string Description { get; set; } = string.Empty;
        
        public string Category { get; set; } = string.Empty; // e.g., Vaccine, Medication, Food
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal CostPrice { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal SellingPrice { get; set; }
        
        public int QuantityOnHand { get; set; }
    }
}
