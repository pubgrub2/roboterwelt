using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Roboterwelt_VLG
{
    public partial class Form1 : Form
    {
        // Hier werden die Elemente erzeugt...
        int aufgabe = 5;
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
        Random rand = new Random();

        public Form1()
        {
            
            InitializeComponent();
            Initialize();


            //.... und hier auf der Welt platziert


            initItems();


        }

        private void initItems()
        {
            for (int i = 1; i < w.gibBreite(); i++)
            {
                for (int j = 1; j < w.gibHoehe(); j++)
                {
                    w.ElementAbmelden(Convert.ToChar(Convert.ToInt32(i + 64)), j);
                }
            }
            if (aufgabe == 1) // welt aufgabe 1 aktivieren
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

            if (aufgabe == 2) // welt aufgabe 2 aktivieren
            {
                w.ElementHinzufuegen(r, 'b', 6);

                w.ElementHinzufuegen(b1, 'c', 6);
                w.ElementHinzufuegen(b2, 'e', 6);
                w.ElementHinzufuegen(p1, 'd', 6);
                w.ElementHinzufuegen(p2, 'f', 6);
            }

            if (aufgabe == 3) // welt aufgabe 3 aktivieren
            {
                w.ElementHinzufuegen(r, 'b', 6);
                w.ElementHinzufuegen(p1, 'c', 6);
                w.ElementHinzufuegen(p2, 'd', 6);
                w.ElementHinzufuegen(p3, 'e', 6);
                w.ElementHinzufuegen(h1, 'f', 6);
            }

            if (aufgabe == 4) // welt aufgabe 4 aktivieren
            {
                w.ElementHinzufuegen(r, 'b', 6);

                w.ElementHinzufuegen(b1, 'f', 6);

                w.ElementHinzufuegen(p1, 'h', 6);
            }
            if (aufgabe == 5)
            {
                w.ElementHinzufuegen(r, 'c', 8);

                w.ElementHinzufuegen(haus, 'c', 2);

                w.ElementHinzufuegen(b1, 'c', rand.Next(3, 8));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //-----hier kommt der ProgrammierCode des Roboters hin
            if (aufgabe == 1) // steuerung aufgabe 1 aktivieren
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

            if (aufgabe == 2) // steuerung aufgabe 2 aktivieren
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

            if (aufgabe == 3) // steuerung aufgabe 3 aktivieren
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

            if (aufgabe == 4) // steuerung aufgabe 4 aktivieren
            {
                //r.dreheRechts();
                //for (int i = 0; i < 3; i++)
                //{
                //    r.schritt();
                //}
                //r.dreheLinks();
                //r.schritt();
                //r.dreheRechts();
                //r.schritt();
                //r.schritt();
                //r.dreheRechts();
                //r.schritt();
                //r.dreheLinks();
                //r.aufheben();
                r.walkscript("d3wawdwwdwaq");

            }
            if (aufgabe == 5)
            {
                while (r.wasIstVorRobot() != "Haus")
                {

                    if (r.kannLaufen())
                    {
                        r.schritt();
                    }
                    else
                    {
                        r.dreheLinks();
                        r.schritt();
                        r.dreheRechts();
                        r.schritt();
                        r.schritt();
                        r.dreheRechts();
                        if (r.wasIstVorRobot() != "Haus")
                        {
                            r.schritt();
                            r.dreheLinks();
                        }
                    }
                }
                r.schritt();
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
            //groupBox1.Left = ClientSize.Width - 130;
            w.HintergrundFarbe = this.BackColor;

            w.BitmapGeaendert += OnPaint;
            
        }

        private void button_linksdrehen_Click(object sender, EventArgs e)
        {
            r.dreheLinks();
        }

        private void button_schritt_Click(object sender, EventArgs e)
        {
            r.schritt();
        }

        private void button_rechtsdrehen_Click(object sender, EventArgs e)
        {
            r.dreheRechts();
        }

        private void button_umdrehen_Click(object sender, EventArgs e)
        {
            r.umdrehen();
        }

        private void button_aufheben_Click(object sender, EventArgs e)
        {
            r.aufheben();
        }

        private void button_ablegen_Click(object sender, EventArgs e)
        {
            r.ablegen();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W: r.schritt(); break;
                case Keys.A: r.dreheLinks(); break;
                case Keys.D: r.dreheRechts(); break;
                case Keys.S: r.umdrehen(); break;
                case Keys.Q: r.aufheben(); break;
                case Keys.E: r.ablegen(); break;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            
            w.ElementHinzufuegen(p3, Convert.ToChar(rand.Next(65, 65 + w.gibBreite() + 1)), rand.Next(w.gibHoehe() + 1));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            initItems();
        }
    }
}
