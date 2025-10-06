using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roboterwelt_VLG
{
    public partial class Form1 : Form
    {
        // Hier werden die Elemente erzeugt...
        int aufgabe = 3;
        Welt w = new Welt(10, 12);
        Haus haus = new Haus();
        Baum b1 = new Baum();
        Baum b2 = new Baum();
        Baum b3 = new Baum();
        Hindernis h1 = new Hindernis();
        Hindernis h2 = new Hindernis();
        Hindernis h3 = new Hindernis();
        Hindernis h4 = new Hindernis();
        Hindernis h5 = new Hindernis();
        Paket p1 = new Paket();
        Paket p2 = new Paket();
        Paket p3 = new Paket();
        Roboter r = new Roboter();
        public Form1()
        {
            
            InitializeComponent();
            Initialize();

            //.... und hier auf der Welt platziert
            
            

            if (aufgabe == 1) // welt aufgabe 1 deaktivieren
            {
                w.ElementHinzufuegen(haus, 'a', 6);
                
                w.ElementHinzufuegen(r, 'b', 6);

                w.ElementHinzufuegen(b1, 'd', 2);
                w.ElementHinzufuegen(b2, 'c', 8);
                w.ElementHinzufuegen(b3, 'h', 8);

                w.ElementHinzufuegen(h1, 'f', 1);
                w.ElementHinzufuegen(h2, 'c', 3);
                w.ElementHinzufuegen(h3, 'i', 5);
                w.ElementHinzufuegen(h4, 'c', 10);
                w.ElementHinzufuegen(h5, 'h', 11);

                w.ElementHinzufuegen(p1, 'h', 2);
                w.ElementHinzufuegen(p2, 'f', 6);
                w.ElementHinzufuegen(p3, 'c', 11);
            }

            if (aufgabe == 2)
            {
                w.ElementHinzufuegen(r, 'b', 6);

                w.ElementHinzufuegen(b1, 'c', 6);
                w.ElementHinzufuegen(b2, 'e', 6);
                w.ElementHinzufuegen(p1, 'd', 6);
                w.ElementHinzufuegen(p2, 'f', 6);
            }

            if (aufgabe == 3)
            {
                w.ElementHinzufuegen(r, 'b', 6);
                w.ElementHinzufuegen(p1, 'c', 6);
                w.ElementHinzufuegen(p2, 'd', 6);
                w.ElementHinzufuegen(p3, 'e', 6);
                w.ElementHinzufuegen(h1, 'f', 6);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //-----hier kommt der ProgrammierCode des Roboters hin
            if (aufgabe == 1)
            {
                for (int i = 0; i < 1; i++)
                {
                    r.dreheRechts();
                }
                for (int i = 0; i < 3; i++)
                {
                    r.schritt();
                }
                r.aufheben();
                for (int i = 0; i < 2; i++)
                {
                    r.dreheRechts();
                }

                for (int i = 0; i < 4; i++)
                {
                    r.schritt();
                }
            }

            if (aufgabe == 2)
            {
                r.schritt();
                r.dreheRechts();
                int cycles = 2;
                for (int i = 0; i < cycles; i++)
                {
                    for (int y = 0; y < 2; y++)
                    {
                        r.schritt();
                    }
                    r.dreheRechts();
                    r.aufheben();
                    if (i != cycles-1)
                    { r.dreheLinks(); }
                    else
                    { r.dreheRechts(); }
                        
                    
                }
            }

            if (aufgabe == 3)
            {
                r.dreheRechts();
                for (int i = 0; i < 3;  i++)
                {
                    r.aufheben();
                    r.schritt();
                    r.umdrehen();
                    r.ablegen();
                    r.umdrehen();
                }
                
            }

        }



        protected override void OnPaint(PaintEventArgs e)
        {

            Graphics g = this.CreateGraphics();
            g.DrawImage(w.gibWeltBild(), 0, 0);
        }


        private void Initialize()
        {
            this.ClientSize = new Size(w.gibBreite() * 42 + 50 + 150, w.gibHoehe() * 42 + 100);
            DoubleBuffered = true;
            button1.Left = ClientSize.Width - 100;
            w.HintergrundFarbe = this.BackColor;
            w.BitmapGeaendert += OnPaint;
        }

        
    }
}
