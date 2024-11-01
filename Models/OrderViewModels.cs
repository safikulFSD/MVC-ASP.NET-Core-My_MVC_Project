﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace My_Project_MVC.Models
{
    public class OrderViewModels
    {
        [Key]
        public int OrderId { get; set; }
        [Display(Name ="Order Number")]
        public string OrderNumber { get; set; }
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        public double Quantity { get; set; }
        [Display(Name = "Unit Price")]
        public double UnitPrice { get; set; }
        public double Total { get; set; }
    }
}