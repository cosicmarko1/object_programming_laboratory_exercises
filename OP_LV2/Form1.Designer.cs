
namespace OP_LV2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnPoligon = new System.Windows.Forms.RadioButton();
            this.rdBtnKvadrat = new System.Windows.Forms.RadioButton();
            this.rdBtnLinija = new System.Windows.Forms.RadioButton();
            this.rdBtnKruznica = new System.Windows.Forms.RadioButton();
            this.rdBtnElipsa = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdBtnPlava = new System.Windows.Forms.RadioButton();
            this.rdBtnCrvena = new System.Windows.Forms.RadioButton();
            this.rdBtnCrna = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnPoligon);
            this.groupBox1.Controls.Add(this.rdBtnKvadrat);
            this.groupBox1.Controls.Add(this.rdBtnLinija);
            this.groupBox1.Controls.Add(this.rdBtnKruznica);
            this.groupBox1.Controls.Add(this.rdBtnElipsa);
            this.groupBox1.Location = new System.Drawing.Point(686, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graf. objekti";
            // 
            // rdBtnPoligon
            // 
            this.rdBtnPoligon.AutoSize = true;
            this.rdBtnPoligon.Location = new System.Drawing.Point(6, 111);
            this.rdBtnPoligon.Name = "rdBtnPoligon";
            this.rdBtnPoligon.Size = new System.Drawing.Size(60, 17);
            this.rdBtnPoligon.TabIndex = 3;
            this.rdBtnPoligon.TabStop = true;
            this.rdBtnPoligon.Text = "Poligon";
            this.rdBtnPoligon.UseVisualStyleBackColor = true;
            // 
            // rdBtnKvadrat
            // 
            this.rdBtnKvadrat.AutoSize = true;
            this.rdBtnKvadrat.Location = new System.Drawing.Point(6, 88);
            this.rdBtnKvadrat.Name = "rdBtnKvadrat";
            this.rdBtnKvadrat.Size = new System.Drawing.Size(62, 17);
            this.rdBtnKvadrat.TabIndex = 3;
            this.rdBtnKvadrat.TabStop = true;
            this.rdBtnKvadrat.Text = "Kvadrat";
            this.rdBtnKvadrat.UseVisualStyleBackColor = true;
            // 
            // rdBtnLinija
            // 
            this.rdBtnLinija.AutoSize = true;
            this.rdBtnLinija.Location = new System.Drawing.Point(6, 65);
            this.rdBtnLinija.Name = "rdBtnLinija";
            this.rdBtnLinija.Size = new System.Drawing.Size(49, 17);
            this.rdBtnLinija.TabIndex = 3;
            this.rdBtnLinija.TabStop = true;
            this.rdBtnLinija.Text = "Linija";
            this.rdBtnLinija.UseVisualStyleBackColor = true;
            // 
            // rdBtnKruznica
            // 
            this.rdBtnKruznica.AutoSize = true;
            this.rdBtnKruznica.Location = new System.Drawing.Point(6, 42);
            this.rdBtnKruznica.Name = "rdBtnKruznica";
            this.rdBtnKruznica.Size = new System.Drawing.Size(66, 17);
            this.rdBtnKruznica.TabIndex = 3;
            this.rdBtnKruznica.TabStop = true;
            this.rdBtnKruznica.Text = "Kruznica";
            this.rdBtnKruznica.UseVisualStyleBackColor = true;
            this.rdBtnKruznica.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdBtnElipsa
            // 
            this.rdBtnElipsa.AutoSize = true;
            this.rdBtnElipsa.Location = new System.Drawing.Point(6, 19);
            this.rdBtnElipsa.Name = "rdBtnElipsa";
            this.rdBtnElipsa.Size = new System.Drawing.Size(53, 17);
            this.rdBtnElipsa.TabIndex = 2;
            this.rdBtnElipsa.TabStop = true;
            this.rdBtnElipsa.Text = "Elipsa";
            this.rdBtnElipsa.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdBtnPlava);
            this.groupBox2.Controls.Add(this.rdBtnCrvena);
            this.groupBox2.Controls.Add(this.rdBtnCrna);
            this.groupBox2.Location = new System.Drawing.Point(686, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(102, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Boja";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rdBtnPlava
            // 
            this.rdBtnPlava.AutoSize = true;
            this.rdBtnPlava.Location = new System.Drawing.Point(6, 65);
            this.rdBtnPlava.Name = "rdBtnPlava";
            this.rdBtnPlava.Size = new System.Drawing.Size(52, 17);
            this.rdBtnPlava.TabIndex = 3;
            this.rdBtnPlava.TabStop = true;
            this.rdBtnPlava.Text = "Plava";
            this.rdBtnPlava.UseVisualStyleBackColor = true;
            // 
            // rdBtnCrvena
            // 
            this.rdBtnCrvena.AutoSize = true;
            this.rdBtnCrvena.Location = new System.Drawing.Point(6, 42);
            this.rdBtnCrvena.Name = "rdBtnCrvena";
            this.rdBtnCrvena.Size = new System.Drawing.Size(59, 17);
            this.rdBtnCrvena.TabIndex = 3;
            this.rdBtnCrvena.TabStop = true;
            this.rdBtnCrvena.Text = "Crvena";
            this.rdBtnCrvena.UseVisualStyleBackColor = true;
            // 
            // rdBtnCrna
            // 
            this.rdBtnCrna.AutoSize = true;
            this.rdBtnCrna.Location = new System.Drawing.Point(6, 19);
            this.rdBtnCrna.Name = "rdBtnCrna";
            this.rdBtnCrna.Size = new System.Drawing.Size(47, 17);
            this.rdBtnCrna.TabIndex = 3;
            this.rdBtnCrna.TabStop = true;
            this.rdBtnCrna.Text = "Crna";
            this.rdBtnCrna.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtnPoligon;
        private System.Windows.Forms.RadioButton rdBtnKvadrat;
        private System.Windows.Forms.RadioButton rdBtnLinija;
        private System.Windows.Forms.RadioButton rdBtnKruznica;
        private System.Windows.Forms.RadioButton rdBtnElipsa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdBtnPlava;
        private System.Windows.Forms.RadioButton rdBtnCrvena;
        private System.Windows.Forms.RadioButton rdBtnCrna;
    }
}

