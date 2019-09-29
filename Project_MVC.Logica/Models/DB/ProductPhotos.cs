using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_MVC.Logica.Models.DB
{
    public class ProductPhotos
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string Guid { get; set; }
        public string Extension { get; set; }

        public  Products Products { get; set; }
    }
}
