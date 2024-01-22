using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_LV3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            richTextBox.BackColor = DefaultBackColor;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(Path.GetExtension(openFileDialog.FileName)==".txt")
                {
                    this.Text = openFileDialog.FileName;
                    System.IO.StreamReader streamReader = new System.IO.StreamReader(openFileDialog.FileName);
                    richTextBox.Text = streamReader.ReadToEnd();
                    streamReader.Close();
                }
                else
                {
                    richTextBox.LoadFile(openFileDialog.FileName);
                }
            }
        }

        private void btn_SaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.FileName = "probna_tekstualna_datoteka";

            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(Path.GetExtension(saveFileDialog.FileName) == ".txt")
                {
                    richTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
                else
                {
                    richTextBox.SaveFile(saveFileDialog.FileName);
                }
            }
        }

        private void btn_Color_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionColor = colorDialog.Color;
            }
        }

        private void btn_Font_Click(object sender, EventArgs e)
        {
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionFont = fontDialog.Font;
            }
        }

        private System.Drawing.Printing.PrintDocument documentToPrint = new System.Drawing.Printing.PrintDocument();

        private void btn_Print_Click(object sender, EventArgs e)
        {
            printDialog.AllowSomePages = true;
            printDialog.ShowHelp = true;
            printDialog.Document = documentToPrint;
            DialogResult result = printDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                documentToPrint.Print();
            }
        }
    }
}
