using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWithRepository.Core
{
    [DebuggerDisplay($"{{{nameof(DebuggerDisplay)}(),nq}}")]
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [MaxLength(50)]
        public string ProductName { get; set; }
        [Required]
        public int CategoryID { get; set; }
        [Required]
        public string CategoryName { get; set; }
        [Required]
        private string DebuggerDisplay => ToString();
    }
}
