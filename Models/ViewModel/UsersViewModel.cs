﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_Project_MVC.Models.ViewModel
{
    public class UsersViewModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}