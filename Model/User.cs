using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStoreManagementSystem
{
    public class User
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        
        public int roleId { get; set; }
        public Roles roles { get; set; }
    }

    public class Roles
    {
        [Key]
        public int roleId { get; set; }
        public string roleName { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
