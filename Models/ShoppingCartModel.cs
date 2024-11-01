﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Project_MVC.Models
{
    public class ShoppingCartModel
    {
        public int Id { get; set; }
        public string ProductsName { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double Total { get; set; }
        public string ImagePath { get; set; }
        
    }
}