using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSU_PMS.Models
{
    public class ProductDetail
    {
        [Key]
        public string ID { get; set; }
        [Required]
        public string ProductID { get; set; }
        [Required]
        public int StripsLeft { get; set; }
        [Required]
        public int MedicineLeft { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
