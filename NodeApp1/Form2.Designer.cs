﻿namespace NodeApp1
{
    partial class Form2
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
            this.winWordControl1 = new WinWordControl.WinWordControl();
            this.SuspendLayout();
            // 
            // winWordControl1
            // 
            this.winWordControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winWordControl1.Location = new System.Drawing.Point(0, 0);
            this.winWordControl1.Name = "winWordControl1";
            this.winWordControl1.Size = new System.Drawing.Size(800, 450);
            this.winWordControl1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.winWordControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private WinWordControl.WinWordControl winWordControl1;
    }
}