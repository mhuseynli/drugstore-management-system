using System;
using System.Data.Entity;
using System.Linq;

namespace DrugStoreManagementSystem
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("name=ModelContext") { }

        public virtual DbSet<Medicine> Medicine { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<MedicineFormat> MedicineFormat { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
    }
}