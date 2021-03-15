using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShopBridgeMvc.Models
{
    public class mvcItem
    {

        [Required(ErrorMessage = "This Field is Required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public double Price { get; set; }
        //public byte[] Photo { get; set; }
    }
}