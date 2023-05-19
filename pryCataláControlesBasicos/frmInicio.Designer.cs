namespace pryCataláControlesBasicos
{
    partial class frmInicio
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
            this.txtEscribir = new System.Windows.Forms.TextBox();
            this.optRojo = new System.Windows.Forms.RadioButton();
            this.optAzul = new System.Windows.Forms.RadioButton();
            this.cmdAsignar = new System.Windows.Forms.Button();
            this.grbSeleccionar = new System.Windows.Forms.GroupBox();
            this.chkKetchup = new System.Windows.Forms.CheckBox();
            this.chkMayonesa = new System.Windows.Forms.CheckBox();
            this.chkPicante = new System.Windows.Forms.CheckBox();
            this.cmdElegir = new System.Windows.Forms.Button();
            this.lblDuplicar = new System.Windows.Forms.Label();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.lstAdicional = new System.Windows.Forms.ComboBox();
            this.grbSeleccionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEscribir
            // 
            this.txtEscribir.Location = new System.Drawing.Point(223, 30);
            this.txtEscribir.Name = "txtEscribir";
            this.txtEscribir.Size = new System.Drawing.Size(100, 20);
            this.txtEscribir.TabIndex = 1;
            this.txtEscribir.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // optRojo
            // 
            this.optRojo.AutoSize = true;
            this.optRojo.Location = new System.Drawing.Point(68, 89);
            this.optRojo.Name = "optRojo";
            this.optRojo.Size = new System.Drawing.Size(47, 17);
            this.optRojo.TabIndex = 2;
            this.optRojo.TabStop = true;
            this.optRojo.Text = "Rojo";
            this.optRojo.UseVisualStyleBackColor = true;
            // 
            // optAzul
            // 
            this.optAzul.AutoSize = true;
            this.optAzul.Location = new System.Drawing.Point(164, 89);
            this.optAzul.Name = "optAzul";
            this.optAzul.Size = new System.Drawing.Size(45, 17);
            this.optAzul.TabIndex = 3;
            this.optAzul.TabStop = true;
            this.optAzul.Text = "Azul";
            this.optAzul.UseVisualStyleBackColor = true;
            // 
            // cmdAsignar
            // 
            this.cmdAsignar.Location = new System.Drawing.Point(239, 86);
            this.cmdAsignar.Name = "cmdAsignar";
            this.cmdAsignar.Size = new System.Drawing.Size(75, 23);
            this.cmdAsignar.TabIndex = 4;
            this.cmdAsignar.Text = "Asignar";
            this.cmdAsignar.UseVisualStyleBackColor = true;
            this.cmdAsignar.Click += new System.EventHandler(this.button1_Click);
            // 
            // grbSeleccionar
            // 
            this.grbSeleccionar.Controls.Add(this.chkKetchup);
            this.grbSeleccionar.Controls.Add(this.chkMayonesa);
            this.grbSeleccionar.Controls.Add(this.chkPicante);
            this.grbSeleccionar.Location = new System.Drawing.Point(50, 136);
            this.grbSeleccionar.Name = "grbSeleccionar";
            this.grbSeleccionar.Size = new System.Drawing.Size(200, 100);
            this.grbSeleccionar.TabIndex = 5;
            this.grbSeleccionar.TabStop = false;
            this.grbSeleccionar.Text = "Seleccionar";
            // 
            // chkKetchup
            // 
            this.chkKetchup.AutoSize = true;
            this.chkKetchup.Location = new System.Drawing.Point(18, 77);
            this.chkKetchup.Name = "chkKetchup";
            this.chkKetchup.Size = new System.Drawing.Size(66, 17);
            this.chkKetchup.TabIndex = 2;
            this.chkKetchup.Text = "Ketchup";
            this.chkKetchup.UseVisualStyleBackColor = true;
            // 
            // chkMayonesa
            // 
            this.chkMayonesa.AutoSize = true;
            this.chkMayonesa.Location = new System.Drawing.Point(18, 54);
            this.chkMayonesa.Name = "chkMayonesa";
            this.chkMayonesa.Size = new System.Drawing.Size(75, 17);
            this.chkMayonesa.TabIndex = 1;
            this.chkMayonesa.Text = "Mayonesa";
            this.chkMayonesa.UseVisualStyleBackColor = true;
            // 
            // chkPicante
            // 
            this.chkPicante.AutoSize = true;
            this.chkPicante.Location = new System.Drawing.Point(18, 30);
            this.chkPicante.Name = "chkPicante";
            this.chkPicante.Size = new System.Drawing.Size(62, 17);
            this.chkPicante.TabIndex = 0;
            this.chkPicante.Text = "Picante";
            this.chkPicante.UseVisualStyleBackColor = true;
            // 
            // cmdElegir
            // 
            this.cmdElegir.Location = new System.Drawing.Point(78, 243);
            this.cmdElegir.Name = "cmdElegir";
            this.cmdElegir.Size = new System.Drawing.Size(140, 23);
            this.cmdElegir.TabIndex = 6;
            this.cmdElegir.Text = "Elegir";
            this.cmdElegir.UseVisualStyleBackColor = true;
            this.cmdElegir.Click += new System.EventHandler(this.cmdElegir_Click);
            // 
            // lblDuplicar
            // 
            this.lblDuplicar.AutoSize = true;
            this.lblDuplicar.Location = new System.Drawing.Point(50, 36);
            this.lblDuplicar.Name = "lblDuplicar";
            this.lblDuplicar.Size = new System.Drawing.Size(0, 13);
            this.lblDuplicar.TabIndex = 7;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(50, 290);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(0, 13);
            this.lblSeleccion.TabIndex = 8;
            // 
            // lstAdicional
            // 
            this.lstAdicional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstAdicional.FormattingEnabled = true;
            this.lstAdicional.Location = new System.Drawing.Point(88, 282);
            this.lstAdicional.Name = "lstAdicional";
            this.lstAdicional.Size = new System.Drawing.Size(121, 21);
            this.lstAdicional.TabIndex = 9;
            this.lstAdicional.SelectedIndexChanged += new System.EventHandler(this.lstAdicional_SelectedIndexChanged);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 340);
            this.Controls.Add(this.lstAdicional);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.lblDuplicar);
            this.Controls.Add(this.cmdElegir);
            this.Controls.Add(this.grbSeleccionar);
            this.Controls.Add(this.cmdAsignar);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.txtEscribir);
            this.Name = "frmInicio";
            this.Text = "v";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.grbSeleccionar.ResumeLayout(false);
            this.grbSeleccionar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEscribir;
        private System.Windows.Forms.TextBox txtEscribir;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.Button cmdAsignar;
        private System.Windows.Forms.GroupBox grbSeleccionar;
        private System.Windows.Forms.CheckBox chkKetchup;
        private System.Windows.Forms.CheckBox chkMayonesa;
        private System.Windows.Forms.CheckBox chkPicante;
        private System.Windows.Forms.Button cmdElegir;
        private System.Windows.Forms.Label lblDuplicar;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.ComboBox lstAdicional;
        //private System.Windows.Forms.Label lblEscribir;
    }
}