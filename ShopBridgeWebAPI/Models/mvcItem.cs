using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopBridgeWebAPI.Models
{
    public class mvcItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        //public byte[] Photo { get; set; }
    }
}