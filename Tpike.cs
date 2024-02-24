using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquarium
{
    internal class Tpike:TFish
    {
        public Tpike Next;
        public Tpike CreateNext()
        {
            if (Next == null)
            {
                Tpike newNext = new Tpike(Spead,Size);
                Next = newNext;
                return newNext;
            }
            return null;
        }
        public Tpike( float spead, float size)
        {
            ChangeDirection();
            Spead = spead;
            Size = size;
            Color = Color.Green;
        }
        public override void Draw(Bitmap bm)
        {
            base.Draw(bm);

            Graphics gr = Graphics.FromImage(bm);

            double angleDirSin = Math.Asin(Direction.Y);
            double angleDirCos = Math.Acos(Direction.X);
            double offsetAngle = Math.PI / 180 * 145;

            PointF fp = new PointF(Position.X + Size * (float)Math.Cos(angleDirCos + offsetAngle),
                Position.Y + Size * (float)Math.Sin(angleDirSin + offsetAngle));
            PointF sp = new PointF(Position.X + Size * (float)Math.Cos(angleDirCos - offsetAngle),
                Position.Y + Size * (float)Math.Sin(angleDirSin - offsetAngle));

            Brush br = new SolidBrush(Color);

            //gr.FillPolygon(br, new PointF[] { fp, Position, sp }); // trigon
            gr.DrawPolygon(new Pen(Color, 3), new PointF[] { fp, Position, sp, Position, }); // arrow
        }
        public int EatNearby(Tkarp karpH,float radius)
        {
            if (karpH == null) return -1;
            //find nearbest
            float len(PointF p1, PointF p2)
            {
                float dx = p1.X- p2.X;
                float dy = p1.Y- p2.Y;
                return (float) Math.Sqrt(dx * dx + dy * dy);
            }
            int i = 0;
            int count = 0;
            Tkarp Nearbest = karpH;
            float minlen = len(karpH.Position, this.Position);
            Tkarp next = karpH.Next;
            while (next != null)
            {
                i++;
                if(len(next.Position, this.Position) < minlen)
                {
                    minlen = len(next.Position, this.Position);
                    Nearbest = next;
                    count = i;
                }
                next = next.Next;
            }
            //eat
            if (len(Nearbest.Position, this.Position) < radius){
                return count;
            }
            return -1;
        }
    }
}
