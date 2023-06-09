using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Tienda_DataBase;

namespace DataBase
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
        
        public virtual ICollection<CurrentAccount> CurrentAccount { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }

    }
}
