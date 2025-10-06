using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Roboterwelt_VLG
{
    class Baum:Element
    {
        public Baum()
        {
            Typ = "Baum";
            Begehbar = false;
            wrk = new Bitmap("..\\..\\Bilder\\Baum.bmp");
        }
    }
}
