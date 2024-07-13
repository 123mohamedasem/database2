using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_database
{
    public   class customer
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Column(TypeName ="nvarchar")]
        public string CustomerName { get; set;}

        [MaxLength(80)]
        [Column(TypeName = "nvarchar")]

        public string CustomerEmail { get; set;}

        public string creditcardnumber { get; set;}

    }
}
