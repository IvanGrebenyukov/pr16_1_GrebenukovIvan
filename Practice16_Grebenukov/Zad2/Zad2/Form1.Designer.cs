namespace Zad2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonText = new System.Windows.Forms.Button();
            this.buttonZad1 = new System.Windows.Forms.Button();
            this.buttonZad2 = new System.Windows.Forms.Button();
            this.buttonZad3 = new System.Windows.Forms.Button();
            this.listBoxArray = new System.Windows.Forms.ListBox();
            this.listBoxZad1_2 = new System.Windows.Forms.ListBox();
            this.labelCountDigit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonText
            // 
            this.buttonText.Location = new System.Drawing.Point(10, 3);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(126, 23);
            this.buttonText.TabIndex = 1;
            this.buttonText.Text = "Считать из файла";
            this.buttonText.UseVisualStyleBackColor = true;
            this.buttonText.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonZad1
            // 
            this.buttonZad1.Location = new System.Drawing.Point(249, 32);
            this.buttonZad1.Name = "buttonZad1";
            this.buttonZad1.Size = new System.Drawing.Size(126, 23);
            this.buttonZad1.TabIndex = 2;
            this.buttonZad1.Text = "Задание1";
            this.buttonZad1.UseVisualStyleBackColor = true;
            this.buttonZad1.Click += new System.EventHandler(this.buttonZad1_Click);
            // 
            // buttonZad2
            // 
            this.buttonZad2.Location = new System.Drawing.Point(249, 61);
            this.buttonZad2.Name = "buttonZad2";
            this.buttonZad2.Size = new System.Drawing.Size(126, 23);
            this.buttonZad2.TabIndex = 3;
            this.buttonZad2.Text = "Задание 2";
            this.buttonZad2.UseVisualStyleBackColor = true;
            this.buttonZad2.Click += new System.EventHandler(this.buttonZad2_Click);
            // 
            // buttonZad3
            // 
            this.buttonZad3.Location = new System.Drawing.Point(249, 90);
            this.buttonZad3.Name = "buttonZad3";
            this.buttonZad3.Size = new System.Drawing.Size(126, 23);
            this.buttonZad3.TabIndex = 4;
            this.buttonZad3.Text = "Задание 3";
            this.buttonZad3.UseVisualStyleBackColor = true;
            this.buttonZad3.Click += new System.EventHandler(this.buttonZad3_Click);
            // 
            // listBoxArray
            // 
            this.listBoxArray.FormattingEnabled = true;
            this.listBoxArray.ItemHeight = 15;
            this.listBoxArray.Location = new System.Drawing.Point(10, 32);
            this.listBoxArray.Name = "listBoxArray";
            this.listBoxArray.Size = new System.Drawing.Size(233, 184);
            this.listBoxArray.TabIndex = 6;
            // 
            // listBoxZad1_2
            // 
            this.listBoxZad1_2.FormattingEnabled = true;
            this.listBoxZad1_2.ItemHeight = 15;
            this.listBoxZad1_2.Location = new System.Drawing.Point(390, 50);
            this.listBoxZad1_2.Name = "listBoxZad1_2";
            this.listBoxZad1_2.Size = new System.Drawing.Size(233, 184);
            this.listBoxZad1_2.TabIndex = 7;
            this.listBoxZad1_2.Visible = false;
            // 
            // labelCountDigit
            // 
            this.labelCountDigit.AutoSize = true;
            this.labelCountDigit.Location = new System.Drawing.Point(390, 32);
            this.labelCountDigit.Name = "labelCountDigit";
            this.labelCountDigit.Size = new System.Drawing.Size(38, 15);
            this.labelCountDigit.TabIndex = 8;
            this.labelCountDigit.Text = "label1";
            this.labelCountDigit.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCountDigit);
            this.Controls.Add(this.listBoxZad1_2);
            this.Controls.Add(this.listBoxArray);
            this.Controls.Add(this.buttonZad3);
            this.Controls.Add(this.buttonZad2);
            this.Controls.Add(this.buttonZad1);
            this.Controls.Add(this.buttonText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonText;
        private System.Windows.Forms.Button buttonZad1;
        private System.Windows.Forms.Button buttonZad2;
        private System.Windows.Forms.Button buttonZad3;
        private System.Windows.Forms.ListBox listBoxArray;
        private System.Windows.Forms.ListBox listBoxZad1_2;
        private System.Windows.Forms.Label labelCountDigit;
    }
}
