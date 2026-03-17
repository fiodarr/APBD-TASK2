using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_TASK2.Models
{
    public class Camera : Equipment
    {

        public int Resolution { get; set; }
        public string Type { get; set; }

        public Camera(string name, int res, string type )
            : base(name)
        {
            Resolution = res;
            Type = type;
        }
    }
}
