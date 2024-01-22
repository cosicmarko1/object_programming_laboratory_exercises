using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_LV2
{
    class Linija : GrafObj
    {
        public Point koordinata2;

        public Linija() : base() { }

        public Linija(Pen pen, Point koordinata, Point koordinata2) : base()
        {
            this.SetColor(pen.Color);
            this.koordinata = koordinata;
            this.koordinata2 = koordinata2;
        }

        public void DrawGrafObj(Graphics graphics)
        {
            Pen pen = new Pen(this.GetColor());
            graphics.DrawLine(pen, koordinata, koordinata2);
        }
    }
}
