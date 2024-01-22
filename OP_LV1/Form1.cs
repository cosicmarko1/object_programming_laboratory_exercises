using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_LV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int counter_btn1 = 0;
        protected void button1_Click(object sender, EventArgs e)
        {
            counter_btn1++;
            label1.Text = $"Tipka 1 pritisnuta {counter_btn1} puta";
            label3.Text = "Upravo je pritisnuta tipka 1.";
        }

        private int counter_btn2 = 0;
        private void btn2_Click(object sender, EventArgs e)
        {
            counter_btn2++;
            label2.Text = $"Tipka 2 pritisnuta {counter_btn2} puta";
            label3.Text = "Upravo je pritisnuta tipka 2.";
        }
    }
}
