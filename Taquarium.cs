using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Aquarium
{
    internal class Taquarium
    {
        public Bitmap bm;
        public Tkarp fish;
        public Tpike pike;
        private Panel _panel;
        public Color waterColor = Color.Aqua;
        public Timer timer;
        public Taquarium(Panel panel)
        {
            this.panel = panel;
            bm = new Bitmap(panel.Width, panel.Height);
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += new EventHandler(TickTamer);
        }
        public Panel panel { 
            get { return _panel; } 
            set { _panel = value; bm = new Bitmap(value.Width, value.Height); } 
        }
        public void CreateFishs(int CountPike,int CountCarp)
        {
            Random r = new Random();
            if (CountPike > 0)
            {
                pike = new Tpike( 10, 10);
                pike.RandPosition(r, bm);
                pike.ChangeDirection(r);
                if (CountPike > 1)
                {
                    Tpike next = pike.CreateNext();
                    next.RandPosition(r, bm);
                    next.ChangeDirection(r);
                    for (int i = 2; i < CountPike; i++)
                    {
                        next = next.CreateNext();
                        next.RandPosition(r, bm);
                        next.ChangeDirection(r);
                    }
                }
            }
            if (CountCarp > 0)
            {
                fish = new Tkarp(10, 10);
                fish.RandPosition(r, bm);
                fish.ChangeDirection(r);
                if (CountCarp > 1)
                {
                    Tkarp next = fish.CreateNext();
                    next.RandPosition(r, bm);
                    next.ChangeDirection(r);
                    for (int i = 2; i < CountPike; i++)
                    {
                        next = next.CreateNext();
                        next.RandPosition(r, bm);
                        next.ChangeDirection(r);
                    }
                }
            }
        }
        public void Init()
        {
            CreateFishs(10,10);
            DrawAll();
        }

        private void DrawAll()
        {
            Graphics gr = Graphics.FromImage(bm);
            // water
            Brush br = new SolidBrush(waterColor);
            gr.FillRectangle(br, 0, 0, bm.Width, bm.Height);
            //cleafs
            //sand
            br = new SolidBrush(Color.SandyBrown);
            gr.FillClosedCurve(br, new Point[] { new Point(0, bm.Height), new Point(0, bm.Height - 20), new Point(bm.Width, bm.Height - 10), new Point(bm.Width, bm.Height) });
            //fishs
            fish.Draw(bm);  //karps
            Tkarp nextK = fish.Next;
            while (nextK != null)
            {
                nextK.Draw(bm);
                nextK = nextK.Next;

            }
            
            pike.Draw(bm);  //pikes
            Tpike nextP = pike.Next;
            while (nextP != null)
            {
                nextP.Draw(bm);
                nextP = nextP.Next;

            }

            panel.CreateGraphics().DrawImage(bm, 0, 0);
        }

        public void Run()
        {
            timer.Start();
        }
        private void TickTamer(Object myObject, EventArgs myEventArgs)
        {
            fish.Run(bm, waterColor);
            Tkarp nextK = fish.Next;
            while (nextK != null)
            {
                nextK.Run(bm, waterColor);
                nextK = nextK.Next;

            }
            pike.Run(bm, waterColor);
            
            Tpike nextP = pike.Next;
            while (nextP != null)
            {
                nextP.Run(bm,waterColor);
                nextP = nextP.Next;

            }
            //MessageBox.Show(pike.Position.X + " " + pike.Position.Y);


            DrawAll();
        }
    }
}
