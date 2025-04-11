using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSU_PMS.Models
{
    public class Sale
    {
        [Key]
        public string ID { get; set; }
        public string ClientID { get; set; }
        public int Quantity {  get; set; }
        public double Total {  get; set; }
        public double Discount { get; set; }
        public double SubTotal { get; set; }
        public string Status { get; set; }
        public DateTime DateTime { get; set; }

    }
}
