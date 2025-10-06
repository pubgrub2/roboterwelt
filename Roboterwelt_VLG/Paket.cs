using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Roboterwelt_VLG
{
    class Paket:Element
    {
        public Paket()
        {
            Begehbar = false;
            Aufnehmbar = true;
            Typ = "Paket";
            wrk=new Bitmap("..\\..\\Bilder\\Paket.bmp");
        }
    }
}
