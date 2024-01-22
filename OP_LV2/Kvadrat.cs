using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_LV2
{
    class Kvadrat : Linija
    {
        public int a;

        public Kvadrat() : base() { }

        public Kvadrat(Pen pen, Point koordinata, int a) : base()
        {
            this.SetColor(pen.Color);
            this.koordinata = koordinata;
            this.a = a;
        }

        public void DrawGrafObj(Graphics graphics)
        {
            Pen pen = new Pen(this.GetColor());
            graphics.DrawRectangle(pen, this.koordinata.X, this.koordinata.Y, a, a);
        }
    }
}
