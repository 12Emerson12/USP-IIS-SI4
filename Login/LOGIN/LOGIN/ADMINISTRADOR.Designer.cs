﻿namespace LOGIN
{
    partial class ADMINISTRADOR
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
            this.label1 = new System.Windows.Forms.Label();
            this.LABELADMINISTRADOR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRADOR";
            // 
            // LABELADMINISTRADOR
            // 
            this.LABELADMINISTRADOR.AutoSize = true;
            this.LABELADMINISTRADOR.Location = new System.Drawing.Point(210, 107);
            this.LABELADMINISTRADOR.Name = "LABELADMINISTRADOR";
            this.LABELADMINISTRADOR.Size = new System.Drawing.Size(0, 13);
            this.LABELADMINISTRADOR.TabIndex = 1;
            // 
            // ADMINISTRADOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 268);
            this.Controls.Add(this.LABELADMINISTRADOR);
            this.Controls.Add(this.label1);
            this.Name = "ADMINISTRADOR";
            this.Text = "ADMINISTRADOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LABELADMINISTRADOR;
    }
}