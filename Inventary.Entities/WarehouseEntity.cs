﻿using System;
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
        public string WarehouseId { get; set; }
        
        [Required]
        [StringLength(100)]
        public string WarehouseName { get; set; }
        
        [Required]
        [StringLength(200)]
        public string WarehouseAddress { get; set; }

        public ICollection<StorageEntity> Storages { get; set; }
    }
}
