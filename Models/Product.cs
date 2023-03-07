using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Project_Satish.Models
{
    public class Product
    {
        internal int productId;

        [Key]
        [Required]
        [DisplayName("ProductId")]
        public int ProductID { get; set; }


        [Required]
        [DisplayName("ProductName")]
        public string ProductName { get; set; }

        [Required]
        [DisplayName("CategoryId")]
        public int CategoryId{ get; set; }


        [Required]
        [DisplayName("CategoryName")]
        public string CategoryName{ get; set; }


    }
}