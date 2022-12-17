using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventary.Entities
{
    public class InOutEntity
    {
        [Key]
        [StringLength(50)]
        public string InOutId { get; set; }

        [Required]
        public DateTime InOutDate { get; set; }
        
        [Required]
        public int Quantity { get; set; }
        
        [Required]
        public bool IsInput { get; set; }
        
        [Required]
        [StringLength(50)]
        public string StorageId { get; set; }
        public StorageEntity Storage { get; set; }
    }
}
