using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_LV5_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Random random = new Random();
        string[] colors = { "black", "red", "green", "blue", "yellow", "purple", "white", "azure", "maroon", "tomato", "orange", "cyan", "navy", "khaki" };
        TcpClient client;
        NetworkStream stream;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client = new TcpClient("localhost", 8000);
            stream = client.GetStream();
            panelConnectionStatus.BackColor = Color.Green;
        }

        private void btnCloseConnection_Click(object sender, EventArgs e)
        {
            stream.Close();
            client.Close();
            panelConnectionStatus.BackColor = Color.Red;
        }

        private void sendObject(string value)
        {
            if(panelConnectionStatus.BackColor == Color.Green)
            {
                int byteCount = Encoding.ASCII.GetByteCount(value); 
                byte[] sendData = new byte[byteCount]; 
                sendData = Encoding.ASCII.GetBytes(value); 
                stream.Write(sendData, 0, sendData.Length); 
            }
        }

        private void linijaBtnRandom_Click(object sender, EventArgs e)
        {
            double x1 = random.Next(800) * Math.Round(random.NextDouble(), 2);
            double y1 = random.Next(600) * Math.Round(random.NextDouble(), 2);
            double x2 = random.Next(800) * Math.Round(random.NextDouble(), 2);
            double y2 = random.Next(600) * Math.Round(random.NextDouble(), 2);
            string color = colors[random.Next(colors.Count())];

            linijaTxtBox1.Text = x1.ToString();
            linijaTxtBox2.Text = y1.ToString();
            linijaTxtBox3.Text = x2.ToString();
            linijaTxtBox4.Text = y2.ToString();
            linijaTxtBoxBoja.Text = color;
        }

        private void trokutBtnRandom_Click(object sender, EventArgs e)
        {
            double x1 = random.Next(800) * Math.Round(random.NextDouble(), 2);
            double y1 = random.Next(600) * Math.Round(random.NextDouble(), 2);
            double x2 = random.Next(800) * Math.Round(random.NextDouble(), 2);
            double y2 = random.Next(600) * Math.Round(random.NextDouble(), 2);
            double x3 = random.Next(800) * Math.Round(random.NextDouble(), 2);
            double y3 = random.Next(600) * Math.Round(random.NextDouble(), 2);
            string color = colors[random.Next(colors.Count())];

            trokutTxtBox1.Text = x1.ToString();
            trokutTxtBox2.Text = y1.ToString();
            trokutTxtBox3.Text = x2.ToString();
            trokutTxtBox4.Text = y2.ToString();
            trokutTxtBox5.Text = x3.ToString();
            trokutTxtBox6.Text = y3.ToString();
            trokutTxtBoxBoja.Text = color;
        }

        private void pravokutnikBtnRandom_Click(object sender, EventArgs e)
        {
            double x1 = random.Next(800) * Math.Round(random.NextDouble(), 2);
            double y1 = random.Next(600) * Math.Round(random.NextDouble(), 2);
            double sirina = random.Next(Convert.ToInt32(800 - x1));
            double visina = random.Next(Convert.ToInt32(600 - y1));
            string color = colors[random.Next(colors.Count())];

            pravokutnikTxtBox1.Text = x1.ToString();
            pravokutnikTxtBox2.Text = y1.ToString();
            pravokutnikTxtBox3.Text = visina.ToString();
            pravokutnikTxtBox4.Text = sirina.ToString();
            pravokutnikTxtBoxBoja.Text = color;
        }

        private void poligonBtnAddPoint_Click(object sender, EventArgs e)
        {
            if(poligonTxtBox1.TextLength > 0 && poligonTxtBox2.TextLength > 0)
            {
                poligonListBox.Items.Add(poligonTxtBox1.Text);
                poligonListBox.Items.Add(poligonTxtBox2.Text);
            }
        }

        private void poligonBtnRandom_Click(object sender, EventArgs e)
        {
            double[] points1 = new double[] { 64.0, 70.0, 63.0, 29.0, 27.9, 56.2, 66.7, 114.9, 89.6, 75.6, 87.3, 75.2, 64.3, 91.0 };
            double[] points2 = new double[] { 66, 177, 72.0, 176.3, 48.7, 152.9, 58.9, 180.1 };
            double[] points3 = new double[] { 157, 100, 189.4, 59.9, 136.7, 100.5, 164.9, 86.9 };
            double[] points4 = new double[] { 148, 191, 194.9, 203.1, 196.7, 219.2, 207.2, 86.9 };
            double[] points5 = new double[] { 98, 203, 51.6, 207.0, 141.0, 216.9, 110.4, 174.5, 78.4, 172.9, 108.2, 204.4 };
            double[] points6 = new double[] { 127, 143, 93.1, 95.1, 85.0, 162.6, 120.1, 188.7, 167.3, 123.6, 161.6, 121.4 };

            poligonListBox.Items.Clear();
            int odabirPolja = random.Next(5);
            double pomak = Convert.ToDouble(random.Next(60));
            int goreDolje = random.Next(0, 2);
            if(goreDolje == 2)
            {
                pomak = pomak * -1;
            }
            if(goreDolje == 1)
            {
                pomak = pomak * 2;
            }
            switch(odabirPolja)
            {
                case 0:
                    for(int i=0; i<points1.Length; i++)
                    {
                        poligonListBox.Items.Add(points1[i] + Convert.ToDouble(pomak));
                    }
                    break;
                case 1:
                    for (int i = 0; i < points2.Length; i++)
                    {
                        poligonListBox.Items.Add(points2[i] + Convert.ToDouble(pomak));
                    }
                    break;
                case 2:
                    for (int i = 0; i < points3.Length; i++)
                    {
                        poligonListBox.Items.Add(points3[i] + Convert.ToDouble(pomak));
                    }
                    break;
                case 3:
                    for (int i = 0; i < points4.Length; i++)
                    {
                        poligonListBox.Items.Add(points4[i] + Convert.ToDouble(pomak));
                    }
                    break;
                case 4:
                    for (int i = 0; i < points5.Length; i++)
                    {
                        poligonListBox.Items.Add(points5[i] + Convert.ToDouble(pomak));
                    }
                    break;
                case 5:
                    for (int i = 0; i < points6.Length; i++)
                    {
                        poligonListBox.Items.Add(points6[i] + Convert.ToDouble(pomak));
                    }
                    break;
            }
            string color = colors[random.Next(colors.Count())];
            poligonTxtBoxBoja.Text = color;
        }

        private void kruznicaBtnRandom_Click(object sender, EventArgs e)
        {
            double x1 = random.Next(800) * Math.Round(random.NextDouble(), 2);
            double y1 = random.Next(600) * Math.Round(random.NextDouble(), 2);
            double radijus = random.Next(Convert.ToInt32(800 - x1)) * Math.Round(random.NextDouble(), 2);
            string color = colors[random.Next(colors.Count())];

            kruznicaTxtBox1.Text = x1.ToString();
            kruznicaTxtBox2.Text = y1.ToString();
            kruznicaTxtBox3.Text = radijus.ToString();
            kruznicaTxtBoxBoja.Text = color;
        }

        private void elipsaBtnRandom_Click(object sender, EventArgs e)
        {
            double x1 = random.Next(800) * Math.Round(random.NextDouble(), 2);
            double y1 = random.Next(600) * Math.Round(random.NextDouble(), 2);
            double radijus1 = random.Next(Convert.ToInt32(800 - x1)) * Math.Round(random.NextDouble(), 2);
            double radijus2 = random.Next(Convert.ToInt32(600 - y1)) * Math.Round(random.NextDouble(), 2);
            string color = colors[random.Next(colors.Count())];

            elipsaTxtBox1.Text = x1.ToString();
            elipsaTxtBox2.Text = y1.ToString();
            elipsaTxtBox3.Text = radijus1.ToString();
            elipsaTxtBox4.Text = radijus2.ToString();
            elipsaTxtBoxBoja.Text = color;
        }

        private void linijaBtnSend_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(linijaTxtBoxBoja.Text) && !String.IsNullOrEmpty(linijaTxtBox1.Text) && !String.IsNullOrEmpty(linijaTxtBox2.Text) && !String.IsNullOrEmpty(linijaTxtBox3.Text) && !String.IsNullOrEmpty(linijaTxtBox4.Text))
            {
                string linija = "Line " + linijaTxtBoxBoja.Text + " " + linijaTxtBox1.Text + " " + linijaTxtBox2.Text + " " + linijaTxtBox3.Text + " " + linijaTxtBox4.Text;
                sendObject(linija);
            }
        }

        private void trokutBtnSend_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(trokutTxtBoxBoja.Text) && !String.IsNullOrEmpty(trokutTxtBox1.Text) && !String.IsNullOrEmpty(trokutTxtBox2.Text) && !String.IsNullOrEmpty(trokutTxtBox3.Text) && !String.IsNullOrEmpty(trokutTxtBox4.Text) && !String.IsNullOrEmpty(trokutTxtBox5.Text) && !String.IsNullOrEmpty(trokutTxtBox6.Text))
            {
                string trokut = "Triangle " + trokutTxtBoxBoja.Text + " " + trokutTxtBox1.Text + " " + trokutTxtBox2.Text + " " + trokutTxtBox3.Text + " " + trokutTxtBox4.Text + " " + trokutTxtBox5.Text + " " + trokutTxtBox6.Text;
                sendObject(trokut);
            }
        }

        private void pravokutnikBtnSend_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(pravokutnikTxtBoxBoja.Text) && !String.IsNullOrEmpty(pravokutnikTxtBox1.Text) && !String.IsNullOrEmpty(pravokutnikTxtBox2.Text) && !String.IsNullOrEmpty(pravokutnikTxtBox3.Text) && !String.IsNullOrEmpty(pravokutnikTxtBox4.Text))
            {
                string pravokutnik = "Rectangle " + pravokutnikTxtBoxBoja.Text + " " + pravokutnikTxtBox1.Text + " " + pravokutnikTxtBox2.Text + " " + pravokutnikTxtBox3.Text + " " + pravokutnikTxtBox4.Text;
                sendObject(pravokutnik);
            }
        }

        private void poligonBtnSend_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(poligonTxtBoxBoja.Text) && poligonListBox.Items.Count > 0)
            {
                System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
                foreach(object koordinata in poligonListBox.Items)
                {
                    stringBuilder.Append(koordinata.ToString());
                    stringBuilder.Append(" ");
                }
                string poligon = "Polygon " + poligonTxtBoxBoja.Text + " " + stringBuilder.ToString();
                sendObject(poligon);
            }
        }

        private void kruznicaBtnSend_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(kruznicaTxtBoxBoja.Text) && !String.IsNullOrEmpty(kruznicaTxtBox1.Text) && !String.IsNullOrEmpty(kruznicaTxtBox2.Text) && !String.IsNullOrEmpty(kruznicaTxtBox3.Text))
            {
                string kruznica = "Circle " + kruznicaTxtBoxBoja.Text + " " + kruznicaTxtBox1.Text + " " + kruznicaTxtBox2.Text + " " + kruznicaTxtBox3.Text;
                sendObject(kruznica);
            }
        }

        private void elipsaBtnSend_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(elipsaTxtBoxBoja.Text) && !String.IsNullOrEmpty(elipsaTxtBox1.Text) && !String.IsNullOrEmpty(elipsaTxtBox2.Text) && !String.IsNullOrEmpty(elipsaTxtBox3.Text) && !String.IsNullOrEmpty(elipsaTxtBox4.Text))
            {
                string elipsa = "Ellipse " + elipsaTxtBoxBoja.Text + " " + elipsaTxtBox1.Text + " " + elipsaTxtBox2.Text + " " + elipsaTxtBox3.Text + " " + elipsaTxtBox4.Text;
                sendObject(elipsa);
            }

        }










        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void panelConnectionStatus_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
