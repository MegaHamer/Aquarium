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

        public Tkarp karpH;
        public Tkarp karpT;
        public int karpCount=0;

        public Tpike pikeH;
        public Tpike pikeT;
        public int CountPike=0;

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
            for (int i = 0; i < 0; i++)
            {
                AddPike(r);
            }
            /*
            if (CountPike > 0)
            {
                pikeH = new Tpike( 10, 10);
                pikeH.RandPosition(r, bm);
                pikeH.ChangeDirection(r);
                if (CountPike > 1)
                {
                    Tpike next = pikeH.CreateNext();
                    next.RandPosition(r, bm);
                    next.ChangeDirection(r);
                    for (int i = 2; i < CountPike; i++)
                    {
                        next = next.CreateNext();
                        next.RandPosition(r, bm);
                        next.ChangeDirection(r);
                    }
                }
            }*/
            for (int i = 0; i < 0; i++)
            {
                AddKarp(r);
            }
            /*if (CountCarp > 0)
            {
                
                karpH = new Tkarp(10, 10);
                karpH.RandPosition(r, bm);
                karpH.ChangeDirection(r);
                if (CountCarp > 1)
                {
                    Tkarp next = karpH.CreateNext();
                    next.RandPosition(r, bm);
                    next.ChangeDirection(r);
                    for (int i = 2; i < CountPike; i++)
                    {
                        next = next.CreateNext();
                        next.RandPosition(r, bm);
                        next.ChangeDirection(r);
                    }
                }
            }*/
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
            if (karpH != null)
            {
                karpH.Draw(bm);  //karps
                Tkarp nextK = karpH.Next;
                while (nextK != null)
                {
                    nextK.Draw(bm);
                    nextK = nextK.Next;

                }
            }
            if (pikeH != null)
            {
                pikeH.Draw(bm);  //pikes
                Tpike nextP = pikeH.Next;
                while (nextP != null)
                {
                    nextP.Draw(bm);
                    nextP = nextP.Next;

                }
            }

            panel.CreateGraphics().DrawImage(bm, 0, 0);
        }

        public void Run()
        {
            timer.Start();
        }
        private void TickTamer(Object myObject, EventArgs myEventArgs)
        {
            if (karpH != null)
            {
                karpH.Run(bm, waterColor);
                Tkarp nextK = karpH.Next;
                while (nextK != null)
                {
                    nextK.Run(bm, waterColor);
                    nextK = nextK.Next;

                }
            }
            if (pikeH != null)
            {
                float eatRadius = 5;
                pikeH.Run(bm, waterColor);
                if (pikeH.EatNearby(karpH, eatRadius) >= 0)
                {
                    DelKarp(pikeH.EatNearby(karpH, eatRadius));
                }
                Tpike nextP = pikeH.Next;
                while (nextP != null)
                {
                    nextP.Run(bm,waterColor);

                    if (nextP.EatNearby(karpH, eatRadius) >= 0)
                    {
                        DelKarp(nextP.EatNearby(karpH, eatRadius));
                    }

                    nextP = nextP.Next;

                }
            }

            DrawAll();
        }
        public void AddKarp(Random r)
        {
            
            karpCount++;
            if (karpH == null)
            {
                karpH = new Tkarp(10, 10);
                karpH.RandPosition(r, bm, waterColor);
                karpH.ChangeDirection(r);
                karpT = karpH;
                return;
            }
            karpT = karpT.CreateNext();
            karpT.RandPosition(r, bm,waterColor);
            karpT.ChangeDirection(r);
        }
        public void AddPike(Random r)
        {
            CountPike++;
            if (pikeH == null)
            {
                pikeH = new Tpike(10, 10);
                pikeH.RandPosition(r, bm,waterColor);
                pikeH.ChangeDirection(r);
                pikeT = pikeH;
                return;
            }
            pikeT = pikeT.CreateNext();
            pikeT.RandPosition(r, bm,waterColor);
            pikeT.ChangeDirection(r);
        }
        public void DelKarp(int order)
        {
            if (karpH == null || order < 0)
            {
                //MessageBox.Show("head is null");
                return;
            }
            if (order ==0)
            {
                //MessageBox.Show("delete first");
                karpH = karpH.Next;
                karpCount--;
                return;
            }
            
            Tkarp next = karpH.Next;  // 1
            Tkarp post = karpH;
            if (next == null) { return; }
            for (int i =1; i < order; i++)
            {
                post = next;
                next = next.Next;
                if (next == null)  //array end
                {
                    return;
                }
            }
            if (karpH.Next == null) //delete first
            {
                //MessageBox.Show("delete single first");
                karpH = null;
                karpT = null;
                karpCount--;
                return;
            }
            if (next.Next == null)  // delete last
            {
                //MessageBox.Show("delete last");
               next = null;
                karpT = post;
                karpT.Next = null;
                karpCount--;
                return;
            }
            //delete in middle
            //MessageBox.Show("delete middle");
            post.Next = next.Next;
            next = null;
            karpCount--;
        }
        public void DelPike(int order)
        {
            if (pikeH == null || order < 0)
            {
                //MessageBox.Show("head is null");
                return;
            }
            if (order == 0)
            {
                //MessageBox.Show("delete first");
                pikeH = pikeH.Next;
                CountPike--;
                return;
            }

            Tpike next = pikeH.Next;  // 1
            Tpike post = pikeH;
            if (next == null) { return; }
            for (int i = 1; i < order; i++)
            {
                post = next;
                next = next.Next;
                if (next == null)  //array end
                {
                    return;
                }
            }
            if (pikeH.Next == null) //delete first
            {
                //MessageBox.Show("delete single first");
                pikeH = null;
                pikeT = null;
                CountPike--;
                return;
            }
            if (next.Next == null)  // delete last
            {
                //MessageBox.Show("delete last");
                next = null;
                pikeT = post;
                pikeT.Next = null;
                CountPike--;
                return;
            }
            //delete in middle
            //MessageBox.Show("delete middle");
            post.Next = next.Next;
            next = null;
            CountPike--;
        }
    }
}
