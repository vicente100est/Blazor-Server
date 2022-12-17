using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventary.Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }

        public DateTime LastUpdate { get; set; }
        
        [Required]
        public int PartialQuantity { get; set; }
        
        [Required]
        [StringLength(10)]
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }

        [Required]
        [StringLength(50)]
        public string WherehouseId { get; set; }
        public WarehouseEntity Wherehouse { get; set; }

        public ICollection<InOutEntity> InputOutputs { get; set; }
    }
}
