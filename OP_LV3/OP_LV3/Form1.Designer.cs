
namespace OP_LV3
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.btn_SaveFile = new System.Windows.Forms.Button();
            this.btn_Color = new System.Windows.Forms.Button();
            this.btn_Font = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(13, 13);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(716, 412);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(767, 91);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(88, 32);
            this.btn_OpenFile.TabIndex = 1;
            this.btn_OpenFile.Text = "Open File";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // btn_SaveFile
            // 
            this.btn_SaveFile.Location = new System.Drawing.Point(767, 142);
            this.btn_SaveFile.Name = "btn_SaveFile";
            this.btn_SaveFile.Size = new System.Drawing.Size(88, 32);
            this.btn_SaveFile.TabIndex = 2;
            this.btn_SaveFile.Text = "Save File";
            this.btn_SaveFile.UseVisualStyleBackColor = true;
            this.btn_SaveFile.Click += new System.EventHandler(this.btn_SaveFile_Click);
            // 
            // btn_Color
            // 
            this.btn_Color.Location = new System.Drawing.Point(132, 447);
            this.btn_Color.Name = "btn_Color";
            this.btn_Color.Size = new System.Drawing.Size(88, 32);
            this.btn_Color.TabIndex = 3;
            this.btn_Color.Text = "Color";
            this.btn_Color.UseVisualStyleBackColor = true;
            this.btn_Color.Click += new System.EventHandler(this.btn_Color_Click);
            // 
            // btn_Font
            // 
            this.btn_Font.Location = new System.Drawing.Point(327, 447);
            this.btn_Font.Name = "btn_Font";
            this.btn_Font.Size = new System.Drawing.Size(88, 32);
            this.btn_Font.TabIndex = 4;
            this.btn_Font.Text = "Font";
            this.btn_Font.UseVisualStyleBackColor = true;
            this.btn_Font.Click += new System.EventHandler(this.btn_Font_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(513, 447);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(88, 32);
            this.btn_Print.TabIndex = 5;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 547);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Font);
            this.Controls.Add(this.btn_Color);
            this.Controls.Add(this.btn_SaveFile);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.richTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Button btn_SaveFile;
        private System.Windows.Forms.Button btn_Color;
        private System.Windows.Forms.Button btn_Font;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.PrintDialog printDialog;
    }
}

