using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Roboterwelt_VLG
{
    public delegate void eventHandler(PaintEventArgs e);
    class Welt
    {
        private Bitmap bg;
        private Graphics gr;
        private int b, h;
        private Element[,] feld;
        public eventHandler BitmapGeaendert;
        private int beschriftung = 50;
        private Color hintergrundfarbe;

        public Color HintergrundFarbe
        {
            get { return hintergrundfarbe; }
            set
            {
                hintergrundfarbe = value;
                aktualisiereBitmap();
            }
        }

        public Welt(int spalten, int zeilen)
        {
            b = spalten;
            h = zeilen;
            hintergrundfarbe= Color.DarkOliveGreen;
            feld = new Element[spalten, zeilen];
            bg = new Bitmap(beschriftung+b * 42+4, beschriftung+h * 42+4);
            gr = Graphics.FromImage(bg);
            gr.SmoothingMode = SmoothingMode.HighQuality;
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
            gr.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            aktualisiereBitmap();
        }
        public int gibBreite()
        {
            return b;
        }
        public int gibHoehe()
        {
            return h;
        }

        public void ElementHinzufuegen(Element e,char sp,int zeile)
        {
            sp = char.ToUpper(sp);
            try
            {
                if (e != null)
                {
                    e.Spalte = sp;
                    e.Zeile = zeile;
                    e.w = this;
                }
                feld[sp - 65, zeile - 1] = e;
                aktualisiereBitmap();
            }
            catch (Exception)
            {

                return;
            }
        }
        public Element ElementAbmelden(char sp, int zeile)
        {
            
            try
            {
                sp = char.ToUpper(sp);
                Element tmp = feld[sp - 65, zeile - 1];
                feld[sp - 65, zeile - 1] = null;
                aktualisiereBitmap();
                return tmp;
            }
            catch
            {
                return null;
            }
        }
        public Element gibElement(char sp, int zeile)
        {

            try
            {
                sp = char.ToUpper(sp);
                return feld[sp - 65, zeile - 1];
            }
            catch
            {
                return null;
            }
        }
        public void aktualisiereBitmap()
        {
            int KAESTCHEN_GROESSE = 42;
            gr.Clear(hintergrundfarbe);
            for (int i = 0; i <= b; i++)
            {
                gr.DrawLine(new Pen(new SolidBrush(Color.Black)), beschriftung + 2 + i * KAESTCHEN_GROESSE, beschriftung + 2, beschriftung + 2 + i * KAESTCHEN_GROESSE, beschriftung + 2 + h * KAESTCHEN_GROESSE);
            }
            for (int i = 0; i <= h; i++)
            {
                gr.DrawLine(new Pen(new SolidBrush(Color.Black)), beschriftung + 2, beschriftung + 2 + i * KAESTCHEN_GROESSE, beschriftung + 2 + b * KAESTCHEN_GROESSE, beschriftung + 2 + i * KAESTCHEN_GROESSE);
            }
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    if (feld[i, j] != null)
                    {
                        Bitmap bild = feld[i, j].getBild();
                        bild.MakeTransparent();
                        gr.DrawImage(bild, beschriftung + 3 + i * 42, beschriftung + 3 + j * 42);
                    }
                }
            }
            
            for (int i = 0  ; i < b; i++)
			{
                gr.DrawString((Convert.ToChar(i + 65)).ToString(), new Font("Calibri", 20,FontStyle.Regular), new SolidBrush(Color.Black)  , i * 42 + beschriftung + 15,  beschriftung / 4);
   			}
            for (int j = 0; j < h; j++)
            {
                 gr.DrawString((j+1).ToString(), new Font("Calibri", 20), new SolidBrush(Color.Black),  15, beschriftung+j*42+ 42/ 4); 

            }
            
            if (BitmapGeaendert != null) BitmapGeaendert(null);
        }
        public Bitmap gibWeltBild()
        {       
            return bg;
        }

    }
}
