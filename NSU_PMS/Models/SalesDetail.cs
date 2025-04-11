using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace NSU_PMS.Models
{
    public class SalesDetail
    {
        [Key]
        public string ID { get; set; }
        [Required]
        public string ProductID { get; set; }
        [Required]
        public double Price { get; set; }
        public double Discount {  get; set; }
        public int Quantity { get; set; }


    }
}
