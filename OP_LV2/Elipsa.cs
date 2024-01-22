using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_LV2
{
    class Elipsa : Kruznica
    {
        public int b;

        public Elipsa() : base() { }
            
        public Elipsa(Pen pen, Point koordinata, int a, int b) : base()
        {
            this.SetColor(pen.Color);
            this.koordinata = koordinata;
            this.a = a;
            this.b = b;
        }

        public void DrawGrafObj(Graphics graphics)
        {
            Pen pen = new Pen(this.GetColor());
            graphics.DrawEllipse(pen, koordinata.X, koordinata.Y, a, b);
        }
    }
}
