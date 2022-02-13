using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DevCar_MVC.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
    }
}
