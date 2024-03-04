using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquarium
{
    internal class TFish
    {
        private PointF _position = new PointF(10,10);
        private PointF _direction = new PointF(1,0);
        private float _spead = 10;
        private Color _color = Color.Black;
        private float _size = 30;

        public PointF Position 
        { 
            get { return _position; } 
            set { _position = value; }
        }
        public PointF Direction
        {
            get { return _direction; }
            set { _direction = normalize(value, 1); }
        }
        public float Spead
        {
            get { return _spead; }
            set { if (value >= 0) _spead = value; if (value < 0) _spead = 0; }
        }
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public float Size
        {
            get { return _size; }
            set { if (value <= 0) _size = 1; if (value > 0) _size = value; }
        }
        private PointF normalize(PointF p, float length)
        {
            if (length == 0) return p;
            if (p.X == 0 && p.Y == 0) return normalize(new PointF(1,0),length);
            double len = Math.Sqrt(p.X * p.X + p.Y * p.Y);
            float nx = p.X / (float)len * length, ny = p.Y / (float)len * length;
            return new PointF(nx,ny); 
        }
        public virtual void Draw(Bitmap bm)
        {
        }
        public void Init (PointF position, PointF direction, float spead,  Color color, float size, Bitmap bitmap)
        {
            Position = position;
            Direction = direction;  
            Spead = spead;
            Color = color;
            Size = size;
            Draw(bitmap);
        }
        public LookResult Look (Bitmap bm,Color waterColor)
        {
            float ls = 20; //length of search
            int px = (int) Position.X,//position of fish
                py = (int) Position.Y;
            
            for (int i = 3; i < ls; i++)
            {
                int dx = px + (int)normalize(Direction, i).X, //position of vision
                    dy= py + (int)normalize(Direction, i).Y;


                //MessageBox.Show("83 "+px +" "+ dx);
                if (!(px == dx && py == dy))
                {
                    int ddx = dx-px, ddy = dy-py;
                    float dist = (float) Math.Sqrt(ddx * ddx + ddy * ddy);
                    //MessageBox.Show("94");
                    if (dx >= bm.Width || dx < 0 || dy >= bm.Height || dy < 0) 
                        return new LookResult(waterColor,dist);
                    //MessageBox.Show("97");
                    Color pColor = bm.GetPixel(dx,dy);
                    
                    //MessageBox.Show(bm.GetPixel(dx, dy).B + "blue");
                    if (pColor.ToArgb() != new SolidBrush( waterColor).Color.ToArgb() && pColor.ToArgb() !=Color.ToArgb() )
                    {
                        //MessageBox.Show("101 "+pColor.ToArgb()+" "+ new SolidBrush(waterColor).Color.ToArgb() + "dist "+dist);
                        return new LookResult(pColor,dist);
                    }
                }
            }
            return null;
        }
        internal class LookResult
        {
            public Color color;
            public float distance;
            public LookResult(Color color, float distance)
            {
                this.color = color;
                this.distance = distance;
            }
        }
        public void Run(Bitmap bm,Color waterColor)
        {
            while (Look(bm,waterColor) != null)
            {
                ChangeDirection();
                //MessageBox.Show("122");
                //return;
            }


            PointF vm = normalize(Direction, Spead);
            float x = Position.X + vm.X, y = Position.Y + vm.Y;
            Position = new PointF(x,y);
        }
        public void ChangeDirection()
        {
            Random r = new Random();
            float rx = (float) r.NextDouble()-0.5f, ry = (float)r.NextDouble()-0.5f;
            Direction = new PointF(rx, ry);
        }
        public void ChangeDirection(Random r)
        {
            float rx = (float)r.NextDouble() - 0.5f, ry = (float)r.NextDouble() - 0.5f;
            Direction = new PointF(rx, ry);
        }
        public void RandPosition(Random r,Bitmap bm, Color waterColor)
        {
            Color pColor; int nx, ny;
            do
            {
                nx = r.Next(0, bm.Width - 1); ny = r.Next(0, bm.Height - 1);

                pColor = bm.GetPixel(nx, ny);
            }
            while (pColor.ToArgb() != new SolidBrush(waterColor).Color.ToArgb() && pColor.ToArgb() != Color.ToArgb());
            Position = new PointF(nx,ny);
        }
    }
}
