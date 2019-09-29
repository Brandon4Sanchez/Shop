using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;


namespace Project_MVC.Logica.Models.BindingModels
{
    public class EmployeesCreateBindingModels
    {
        [Required(ErrorMessage ="The field Id is required")]
        [Display(Name ="Id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "The field Fist required")]
        [Display(Name = "Firts Name")]
        public String FirsName { get; set; }
        [Required(ErrorMessage = "The field Second is required")]
        [Display(Name = "Second Name")]
        public String SecondName { get; set; }


    }

    public class EmployeesEditBindingModels
    {

    }
}
