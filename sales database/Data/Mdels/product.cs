using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_database
{
    public class product
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public int quantity { get; set; }

        public int price { get; set; }

         public string description { get; set; }

        

    }
}
