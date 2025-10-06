using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Roboterwelt_VLG
{
    class Roboter : Element
    {
        //public event myDelegateEventHandler bewegt;

        private char dir;
        private char zielSpalte;
        private int zielZeile;
        private List<Element> liste = new List<Element>();
        private Element ueberdeckt = null;

        private Bitmap[] robot;
        public Roboter()
        {
            Typ = "Roboter";
            Begehbar = false;
            Spalte = 'A';
            Zeile = 1;
            dir = 'o';
            robot = new Bitmap[4];
            robot[0] = new Bitmap(@"../../bilder/robot_u_neu.bmp");
            robot[1] = new Bitmap(@"../../bilder/robot_r_neu.bmp");
            robot[2] = new Bitmap(@"../../bilder/robot_o_neu.bmp");
            robot[3] = new Bitmap(@"../../bilder/robot_l_neu.bmp");
            wrk = new Bitmap(robot[2]);
        }
        public void schritt()
        {
            if (pruefeHindernis() == null)
            {
                w.ElementAbmelden(Spalte, Zeile);
               
                if (ueberdeckt != null)
                {
                    w.ElementHinzufuegen(ueberdeckt, Spalte, Zeile);
                    ueberdeckt = null;
                }
                w.ElementHinzufuegen(this, zielSpalte, zielZeile);

            }
            else
            {
                if (pruefeHindernis().Begehbar == false) return;
                else
                {
                    if (ueberdeckt != null) w.ElementHinzufuegen(ueberdeckt, Spalte, Zeile);
                    else w.ElementAbmelden(Spalte, Zeile);
                    ueberdeckt = w.ElementAbmelden(zielSpalte, zielZeile);
                    w.ElementHinzufuegen(this, zielSpalte, zielZeile);
                }
            }
            System.Threading.Thread.Sleep(500);
            w.aktualisiereBitmap();
        }
        public bool kannLaufen()
        {
            berechneZielKoordinaten();
            if (Zeile == zielZeile && Spalte == zielSpalte) return false;
            if (w.gibElement(zielSpalte, zielZeile) == null || w.gibElement(zielSpalte, zielZeile).Begehbar == true) return true;
            return false;
        }
        private Element pruefeHindernis()
        {
            berechneZielKoordinaten();
            if (Zeile == zielZeile && Spalte == zielSpalte) return null;
            return w.gibElement(zielSpalte, zielZeile);
        }
        public string wasIstVorRobot()
        {
            berechneZielKoordinaten();
            if (Zeile == zielZeile && Spalte == zielSpalte) return "Abgrund";
            if (w.gibElement(zielSpalte, zielZeile) == null) return "Nichts";
            return w.gibElement(zielSpalte, zielZeile).Typ;
        }
        /// <summary>
        /// dreht den Roboter nach links
        /// </summary>
        public void dreheLinks()
        {
            switch (dir)
            {
                case 'o':
                    dir = 'l';
                    break;
                case 'l':
                    dir = 'u';
                    break;
                case 'u':
                    dir = 'r';
                    break;
                case 'r':
                    dir = 'o';
                    break;
            }

            System.Threading.Thread.Sleep(200);
            aktualisiereBitmap();
            w.aktualisiereBitmap();
        }
        public void dreheRechts()
        {
            switch (dir)
            {
                case 'o':
                    dir = 'r';
                    break;
                case 'l':
                    dir = 'o';
                    break;
                case 'u':
                    dir = 'l';
                    break;
                case 'r':
                    dir = 'u';
                    break;
            }

            System.Threading.Thread.Sleep(200);
            aktualisiereBitmap();
            w.aktualisiereBitmap();
        }
        /// <summary>
        /// Je nach Ausrichtung wird das Feld "vor" dem Roboter ermittelt. Wenn Er zum rand steht ist sein Zielfeld sein aktuelles
        /// </summary>
        private void berechneZielKoordinaten()
        {
            zielSpalte = Spalte;
            zielZeile = Zeile;
            switch (dir)
            {
                case 'o': if (Zeile > 1) zielZeile = Zeile - 1;
                    break;
                case 'u': if (Zeile < w.gibHoehe()) zielZeile = Zeile + 1;
                    break;
                case 'l': if (Spalte > 'A') zielSpalte = (char)(Spalte - 1);
                    break;
                case 'r': if (Spalte < 'A' + Convert.ToChar(w.gibBreite() - 1)) zielSpalte = (char)(Spalte + 1);
                    break;
            }
        }
        public bool aufheben()
        {
            berechneZielKoordinaten();
            if (Zeile == zielZeile && Spalte==zielSpalte) return false;
            Element tmp=w.gibElement(zielSpalte,zielZeile);
            if(tmp==null||tmp.Aufnehmbar==false) return false;
            w.ElementAbmelden(zielSpalte, zielZeile);
            liste.Add(tmp);
            return true;
        }
        public bool ablegen()
        {
            berechneZielKoordinaten();
            if (Zeile == zielZeile && Spalte == zielSpalte) return false;
            if (liste.Count == 0|| w.gibElement(zielSpalte,zielZeile)!=null) return false;
            Element tmp = liste[0];
            liste.RemoveAt(0);
            w.ElementHinzufuegen(tmp, zielSpalte, zielZeile);
            return true;
        }
        private void aktualisiereBitmap()
        {
            int d = 0;
            switch (dir)
            {
                case 'u': d = 0;
                    break;
                case 'r': d = 1;
                    break;
                case 'o': d = 2;
                    break;
                case 'l': d = 3;
                    break;
            }
            wrk = robot[d];
        }
    }
}
