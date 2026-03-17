using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_TASK2.Models
{
    public class Laptop : Equipment
    {

        public int RamGb { get; set; }
        public int ScreenSize {  get; set; }

        public Laptop(string name, int ram, int screen)
            : base(name)
        {
            RamGb = ram;
            ScreenSize = screen;
        }
    }
}
