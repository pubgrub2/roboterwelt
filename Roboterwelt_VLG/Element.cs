using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Roboterwelt_VLG
{
    class Element
    {
        protected Bitmap wrk;
        public Welt w;
        public Element()
        {
           
        }
        private char spalte;
        public char Spalte
        {
            get { return spalte; }
            set { spalte = value; }
        }
        private int zeile;
        public int Zeile
        {
            get { return zeile; }
            set { zeile = value; }
        }
        private string typ;
        public string Typ
        {
            get { return typ; }
            set { typ = value; }
        }
        private bool begehbar;

        public bool Begehbar
        {
            get { return begehbar; }
            set { begehbar = value; }
        }
        private bool aufnehmbar;

        public bool Aufnehmbar
        {
            get { return aufnehmbar; }
            set { aufnehmbar = value; }
        }
        
        
        public Bitmap getBild()
        {
            return wrk;
        }
    }
}
