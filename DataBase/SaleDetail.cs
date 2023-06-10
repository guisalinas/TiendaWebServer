using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_DataBase
{
    public class SaleDetail
    {
        public int SaleId { get; set; }
        public Sale Sale { get; set; }
        
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
