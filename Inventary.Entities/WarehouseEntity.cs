using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventary.Entities
{
    public class WarehouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WherehouseId { get; set; }
        
        [Required]
        [StringLength(100)]
        public string WherehouseName { get; set; }
        
        [Required]
        [StringLength(200)]
        public string WherehouseAddress { get; set; }

        public ICollection<StorageEntity> Storages { get; set; }
    }
}
