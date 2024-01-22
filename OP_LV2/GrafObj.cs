using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_LV2
{
    class GrafObj
    {
        public Color boja;
        public Point koordinata;

        public GrafObj() { }

        public GrafObj(Color boja, Point koordinata)
        {
            this.boja = boja;
            this.koordinata = koordinata;
        }

        public void SetColor(Color boja) { this.boja = boja; }

        public Color GetColor() { return this.boja; }

        public virtual void DrawGrafObj(GrafObj obj) { }
    }
}
