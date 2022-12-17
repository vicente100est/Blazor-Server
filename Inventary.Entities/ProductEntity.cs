﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventary.Entities
{
    public class ProductEntity
    {
        [Key]
        [StringLength(10)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(1000)]
        public string ProductDescription { get; set; }

        public int TotalQuantity { get; set; }

        public string CategoryId { get; set; }
        public CategoryEntity Category { get; set; }

        public ICollection<StorageEntity> Storages { get; set; }
    }
}
