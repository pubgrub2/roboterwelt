using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Roboterwelt_VLG
{
    class Haus:Element
    {
        public Haus()
        {
            Typ = "Haus";
            Begehbar = true;
            Aufnehmbar = false;
            wrk = new Bitmap("..\\..\\Bilder\\Haus.bmp");
        }
    }
}

