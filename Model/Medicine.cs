using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStoreManagementSystem
{
    public class Inventory
    {
        public int inventoryId { get; set; }
        public int count { get; set; }

        public int medicineId { get; set; }
        public Medicine Medicine { get; set; }
    }

    public class Medicine
    {
        public int medicineId { get; set; }
        public string medicineName { get; set; }
        public int medicineBarcode { get; set; }
        public decimal medicinePrice { get; set; }
        public decimal medicineSellingPrice { get; set; }

        public int categoryId { get; set; }
        public Category Category { get; set; }

        public int manufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }

        public int formatId { get; set; }
        public MedicineFormat MedicineFormat { get; set; }

        public ICollection<Inventory> Inventory { get; set; }
    }

    public class MedicineFormat
    {
        [Key]
        public int formatId { get; set; }
        public string formatName { get; set; }

        public ICollection<Medicine> Medicines { get; set; }
    }

    public class Category
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }

        public ICollection<Medicine> Medicines { get; set; }
    }

    public class Manufacturer
    {
        public int manufacturerId { get; set; }
        public string manufacturerName { get; set; }

        public ICollection<Medicine> Medicines { get; set; }
    }
}
