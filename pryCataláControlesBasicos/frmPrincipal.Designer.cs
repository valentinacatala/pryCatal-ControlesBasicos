﻿namespace pryCataláControlesBasicos
{
    partial class frmPrincipal
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
            this.lblEjeX = new System.Windows.Forms.Label();
            this.lblEjeY = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEjeX
            // 
            this.lblEjeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjeX.AutoSize = true;
            this.lblEjeX.Location = new System.Drawing.Point(400, 17);
            this.lblEjeX.Name = "lblEjeX";
            this.lblEjeX.Size = new System.Drawing.Size(14, 13);
            this.lblEjeX.TabIndex = 0;
            this.lblEjeX.Text = "X";
            // 
            // lblEjeY
            // 
            this.lblEjeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjeY.AutoSize = true;
            this.lblEjeY.Location = new System.Drawing.Point(400, 39);
            this.lblEjeY.Name = "lblEjeY";
            this.lblEjeY.Size = new System.Drawing.Size(14, 13);
            this.lblEjeY.TabIndex = 1;
            this.lblEjeY.Text = "Y";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Location = new System.Drawing.Point(13, 13);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(111, 13);
            this.lblBienvenido.TabIndex = 2;
            this.lblBienvenido.Text = "Bienvenido al Sistema";
            this.lblBienvenido.Visible = false;
            this.lblBienvenido.MouseEnter += new System.EventHandler(this.lblBienvenido_MouseEnter);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.lblEjeY);
            this.Controls.Add(this.lblEjeX);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Titulo de la Ventana";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Click += new System.EventHandler(this.frmPrincipal_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEjeX;
        private System.Windows.Forms.Label lblEjeY;
        private System.Windows.Forms.Label lblBienvenido;
    }
}