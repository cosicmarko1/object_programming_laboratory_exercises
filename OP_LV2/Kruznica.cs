using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_LV2
{
    class Kruznica : GrafObj
    {
        public int a;

        public Kruznica() : base() { }

        public Kruznica(Pen pen, Point koordinata, int a) : base()
        {
            this.SetColor(pen.Color);
            this.koordinata = koordinata;
            this.a = a;
        }

        public void DrawGrafObj(Graphics graphics)
        {
            Pen pen = new Pen(this.GetColor());
            graphics.DrawEllipse(pen, koordinata.X, koordinata.Y, a, a);
        }
    }
}
