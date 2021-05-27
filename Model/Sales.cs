using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStoreManagementSystem
{
    public class Sales
    {
        [Key]
        public int saleId { get; set; }
        public DateTime saleDate { get; set; }
        public decimal profit { get; set; }
    }
}
