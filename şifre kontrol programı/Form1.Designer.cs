﻿namespace şifre_kontrol_programı
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
            kontrolbuton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            pgbGuc = new ProgressBar();
            SuspendLayout();
            // 
            // kontrolbuton
            // 
            kontrolbuton.Location = new Point(210, 243);
            kontrolbuton.Name = "kontrolbuton";
            kontrolbuton.Size = new Size(142, 44);
            kontrolbuton.TabIndex = 0;
            kontrolbuton.Text = "kontrol et";
            kontrolbuton.UseVisualStyleBackColor = true;
            kontrolbuton.Click += kontrolbuton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(210, 209);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 188);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 2;
            label1.Text = " lblSonuc";
            // 
            // pgbGuc
            // 
            pgbGuc.Location = new Point(267, 192);
            pgbGuc.Name = "pgbGuc";
            pgbGuc.Size = new Size(85, 11);
            pgbGuc.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(625, 431);
            Controls.Add(pgbGuc);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(kontrolbuton);
            Name = "Form1";
            Text = "şifre kontrol paneli";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button kontrolbuton;
        private TextBox textBox1;
        private Label label1;
        private ProgressBar pgbGuc;
    }
}
