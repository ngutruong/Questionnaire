using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudMvc.Models
{
    public class MVCProductModel
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}