﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Project_MVC.Logica.Models.ViewModels
{
    public class EmployeesCreateViewModel
    {
        [Display(Name ="Name")]
        public string Name { get; set; }
    }
}
