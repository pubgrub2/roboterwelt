using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Roboterwelt_VLG
{
    class Hindernis:Element
    {
        public Hindernis()
        {
            Typ = "Hindernis";
            Begehbar = false;
            Aufnehmbar = false;
            wrk = new Bitmap("..\\..\\Bilder\\Hindernis.bmp");     
        }
    }
}
