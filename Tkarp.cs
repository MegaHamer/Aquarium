﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class Tkarp:TFish
    {
        public Tkarp Next;
        public Tkarp CreateNext()
        {
            if (Next == null)
            {
                Tkarp newNext = new Tkarp(Spead, Size);
                Next = newNext;
                return newNext;
            }
            return null;
        }
        public Tkarp(float spead, float size)
        {
            ChangeDirection();
            Spead = spead;
            Size = size;
            Color = Color.Red;
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

            gr.FillPolygon(br, new PointF[] { fp, Position, sp }); // trigon
            //gr.DrawPolygon(new Pen(Color, 3), new PointF[] { fp, Position, sp, Position, }); // arrow
        }
    }
}
