using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_LV2
{
    class Poligon : GrafObj
    {
        public Point[] koordinate;

        public Poligon() : base() { }

        public Poligon(Pen pen, Point[] koordinate) : base()
        {
            this.SetColor(pen.Color);
            this.koordinate = koordinate;
        }

        public void DrawGrafObj(Graphics graphics)
        {
            Pen pen = new Pen(this.GetColor());
            graphics.DrawPolygon(pen, koordinate);
        }
    }
}
