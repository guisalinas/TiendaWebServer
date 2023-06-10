using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_DataBase
{
    public class CustomerAddress
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }

    }
}
