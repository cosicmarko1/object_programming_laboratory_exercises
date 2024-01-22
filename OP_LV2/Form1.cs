using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_LV2
{
    public partial class Form1 : Form
    {
        Point mStartPoint, mCurrPoint;
        Pen mDrawPen;
        Graphics mGraphicsHelper;
        private const int PEN_WIDTH = 1;
        bool bMouseDown;
        public int flag = 0;

        List<Linija> linije = new List<Linija>();
        List<Kvadrat> kvadrati = new List<Kvadrat>();
        List<Kruznica> kruznice = new List<Kruznica>();
        List<Elipsa> elipse = new List<Elipsa>();
        List<Poligon> poligoni = new List<Poligon>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bMouseDown = false;
            mGraphicsHelper = this.CreateGraphics();
            mDrawPen = new Pen(Color.Red, PEN_WIDTH);
        }
          
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.mStartPoint = e.Location;
            this.bMouseDown = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // desni klik
            if (e.Button == MouseButtons.Right)
            {

            }
            // lijevi ili srednji klik
            else
            {
                this.bMouseDown = false;
                this.mCurrPoint = e.Location;

                if (flag == 1)
                {
                    Linija linija = new Linija(mDrawPen, this.mStartPoint, this.mCurrPoint);
                    linije.Add(linija);
                    flag = 0;
                }
                else if (flag == 2)
                {
                    Kvadrat kvadrat = new Kvadrat(mDrawPen, this.mStartPoint, this.mCurrPoint.X - this.mStartPoint.X);
                    kvadrati.Add(kvadrat);
                }
                else if (flag == 3)
                {
                    Elipsa elipsa = new Elipsa(mDrawPen, this.mStartPoint, this.mCurrPoint.X - this.mStartPoint.X, this.mCurrPoint.Y - this.mStartPoint.Y);
                    elipse.Add(elipsa);
                }
                else if (flag == 4)
                {
                    Kruznica kruznica = new Kruznica(mDrawPen, this.mStartPoint, this.mCurrPoint.X - this.mStartPoint.X);
                    kruznice.Add(kruznica);
                }
                else if (flag == 5)
                {
                    Point[] tocke = new Point[4];
                    tocke[0] = mStartPoint;
                    tocke[2] = mCurrPoint;
                    tocke[1] = new Point(mCurrPoint.X - 10, mStartPoint.Y - 20);
                    tocke[3] = new Point(mStartPoint.X + 20, mCurrPoint.Y);
                    Poligon poligon = new Poligon(mDrawPen, tocke);
                    poligoni.Add(poligon);
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.bMouseDown == true)
            {
                this.mCurrPoint = e.Location;
                this.Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // crtanje oblika
            flag = 0;
            foreach (Linija linija in linije)
            {
                linija.DrawGrafObj(mGraphicsHelper);
            }
            foreach (Kvadrat kvadrat in kvadrati)
            {
                kvadrat.DrawGrafObj(mGraphicsHelper);
            }
            foreach (Kruznica kruznica in kruznice)
            {
                kruznica.DrawGrafObj(mGraphicsHelper);
            }
            foreach (Elipsa elipsa in elipse)
            {
                elipsa.DrawGrafObj(mGraphicsHelper);
            }
            foreach (Poligon poligon in poligoni)
            {
                poligon.DrawGrafObj(mGraphicsHelper);
            }

            // odabir boje
            if (rdBtnCrna.Checked)
            {
                mDrawPen.Color = Color.Black;
            }
            else if (rdBtnCrvena.Checked)
            {
                mDrawPen.Color = Color.Red;
            }
            else if (rdBtnPlava.Checked)
            {
                mDrawPen.Color = Color.Blue;
            }

            // odabir oblika
            if (rdBtnLinija.Checked)
            {
                mGraphicsHelper.DrawLine(mDrawPen, this.mStartPoint, this.mCurrPoint);
                flag = 1;
            }
            else if (rdBtnKvadrat.Checked)
            {
                mGraphicsHelper.DrawRectangle(mDrawPen, this.mStartPoint.X, this.mStartPoint.Y, this.mCurrPoint.X - this.mStartPoint.X, this.mCurrPoint.X - this.mStartPoint.X);
                flag = 2;
            }
            else if (rdBtnElipsa.Checked)
            {
                Rectangle rect = new Rectangle(this.mStartPoint.X, this.mStartPoint.Y, this.mCurrPoint.X - this.mStartPoint.X, this.mCurrPoint.Y - this.mStartPoint.Y);
                mGraphicsHelper.DrawEllipse(mDrawPen, rect);
                flag = 3;
            }
            else if (rdBtnKruznica.Checked)
            {
                Rectangle rect = new Rectangle(this.mStartPoint.X, this.mStartPoint.Y, this.mCurrPoint.X - this.mStartPoint.X, this.mCurrPoint.X - this.mStartPoint.X);
                mGraphicsHelper.DrawEllipse(mDrawPen, rect);
                flag = 4;
            }
            else if (rdBtnPoligon.Checked)
            {
                Point[] tocke = new Point[4];
                tocke[0] = mStartPoint;
                tocke[2] = mCurrPoint;
                tocke[1] = new Point(mCurrPoint.X - 10, mStartPoint.Y - 20);
                tocke[3] = new Point(mStartPoint.X + 20, mCurrPoint.Y);
                mGraphicsHelper.DrawPolygon(mDrawPen, tocke);
                flag = 5;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
