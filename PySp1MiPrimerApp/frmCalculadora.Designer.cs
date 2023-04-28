namespace PySp1MiPrimerApp
{
    partial class FrmPantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPantallaPrincipal));
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.mrcInicio = new System.Windows.Forms.GroupBox();
            this.mrcExtra = new System.Windows.Forms.GroupBox();
            this.txtSobrante = new System.Windows.Forms.TextBox();
            this.lblSaldoSobrante = new System.Windows.Forms.Label();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.lblGastosExtras = new System.Windows.Forms.Label();
            this.mrcFin = new System.Windows.Forms.GroupBox();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.mrcFijos = new System.Windows.Forms.GroupBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.lblComida = new System.Windows.Forms.Label();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.mrcInicio.SuspendLayout();
            this.mrcExtra.SuspendLayout();
            this.mrcFin.SuspendLayout();
            this.mrcFijos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIngresos
            // 
            this.txtIngresos.Location = new System.Drawing.Point(216, 11);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Size = new System.Drawing.Size(127, 20);
            this.txtIngresos.TabIndex = 1;
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.Location = new System.Drawing.Point(151, 13);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(59, 16);
            this.lblIngresos.TabIndex = 2;
            this.lblIngresos.Text = "Ingresos";
            // 
            // mrcInicio
            // 
            this.mrcInicio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mrcInicio.Controls.Add(this.mrcExtra);
            this.mrcInicio.Controls.Add(this.mrcFin);
            this.mrcInicio.Controls.Add(this.mrcFijos);
            this.mrcInicio.Controls.Add(this.lblIngresos);
            this.mrcInicio.Controls.Add(this.txtIngresos);
            this.mrcInicio.Location = new System.Drawing.Point(0, -3);
            this.mrcInicio.Name = "mrcInicio";
            this.mrcInicio.Size = new System.Drawing.Size(428, 361);
            this.mrcInicio.TabIndex = 3;
            this.mrcInicio.TabStop = false;
            this.mrcInicio.Text = "Inicio";
            this.mrcInicio.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // mrcExtra
            // 
            this.mrcExtra.Controls.Add(this.txtSobrante);
            this.mrcExtra.Controls.Add(this.lblSaldoSobrante);
            this.mrcExtra.Controls.Add(this.txtExtra);
            this.mrcExtra.Controls.Add(this.lblGastosExtras);
            this.mrcExtra.Location = new System.Drawing.Point(121, 178);
            this.mrcExtra.Name = "mrcExtra";
            this.mrcExtra.Size = new System.Drawing.Size(280, 110);
            this.mrcExtra.TabIndex = 9;
            this.mrcExtra.TabStop = false;
            this.mrcExtra.Text = "Saldo Extra";
            this.mrcExtra.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtSobrante
            // 
            this.txtSobrante.Location = new System.Drawing.Point(105, 50);
            this.txtSobrante.Name = "txtSobrante";
            this.txtSobrante.Size = new System.Drawing.Size(100, 20);
            this.txtSobrante.TabIndex = 3;
            // 
            // lblSaldoSobrante
            // 
            this.lblSaldoSobrante.AutoSize = true;
            this.lblSaldoSobrante.Location = new System.Drawing.Point(6, 53);
            this.lblSaldoSobrante.Name = "lblSaldoSobrante";
            this.lblSaldoSobrante.Size = new System.Drawing.Size(80, 13);
            this.lblSaldoSobrante.TabIndex = 2;
            this.lblSaldoSobrante.Text = "Saldo Sobrante";
            this.lblSaldoSobrante.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(105, 24);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(100, 20);
            this.txtExtra.TabIndex = 1;
            // 
            // lblGastosExtras
            // 
            this.lblGastosExtras.AutoSize = true;
            this.lblGastosExtras.Location = new System.Drawing.Point(6, 27);
            this.lblGastosExtras.Name = "lblGastosExtras";
            this.lblGastosExtras.Size = new System.Drawing.Size(62, 13);
            this.lblGastosExtras.TabIndex = 0;
            this.lblGastosExtras.Text = "Gasto Extra";
            this.lblGastosExtras.Click += new System.EventHandler(this.label5_Click);
            // 
            // mrcFin
            // 
            this.mrcFin.Controls.Add(this.cmdGrabar);
            this.mrcFin.Controls.Add(this.cmdCancelar);
            this.mrcFin.Location = new System.Drawing.Point(89, 294);
            this.mrcFin.Name = "mrcFin";
            this.mrcFin.Size = new System.Drawing.Size(332, 53);
            this.mrcFin.TabIndex = 11;
            this.mrcFin.TabStop = false;
            this.mrcFin.Text = "Fin";
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Location = new System.Drawing.Point(9, 16);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(108, 29);
            this.cmdGrabar.TabIndex = 10;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.AccessibleDescription = "";
            this.cmdCancelar.Location = new System.Drawing.Point(196, 16);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(116, 29);
            this.cmdCancelar.TabIndex = 9;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // mrcFijos
            // 
            this.mrcFijos.Controls.Add(this.txtComida);
            this.mrcFijos.Controls.Add(this.txtImpuestos);
            this.mrcFijos.Controls.Add(this.lblComida);
            this.mrcFijos.Controls.Add(this.lblImpuestos);
            this.mrcFijos.Controls.Add(this.txtAlquiler);
            this.mrcFijos.Controls.Add(this.lblAlquiler);
            this.mrcFijos.Location = new System.Drawing.Point(63, 66);
            this.mrcFijos.Name = "mrcFijos";
            this.mrcFijos.Size = new System.Drawing.Size(338, 106);
            this.mrcFijos.TabIndex = 8;
            this.mrcFijos.TabStop = false;
            this.mrcFijos.Text = "Gastos Fijos ";
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(64, 79);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(100, 20);
            this.txtComida.TabIndex = 8;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Location = new System.Drawing.Point(64, 53);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(100, 20);
            this.txtImpuestos.TabIndex = 7;
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Location = new System.Drawing.Point(2, 82);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(42, 13);
            this.lblComida.TabIndex = 6;
            this.lblComida.Text = "Comida";
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Location = new System.Drawing.Point(3, 53);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(55, 13);
            this.lblImpuestos.TabIndex = 5;
            this.lblImpuestos.Text = "Impuestos";
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Location = new System.Drawing.Point(64, 21);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(100, 20);
            this.txtAlquiler.TabIndex = 4;
            this.txtAlquiler.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AccessibleName = "";
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Location = new System.Drawing.Point(3, 24);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(41, 13);
            this.lblAlquiler.TabIndex = 3;
            this.lblAlquiler.Text = "Alquiler";
            // 
            // FrmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 355);
            this.Controls.Add(this.mrcInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPantallaPrincipal";
            this.Text = "Gestion De Gastos";
            this.Load += new System.EventHandler(this.FrmPantallaPrincipal_Load);
            this.mrcInicio.ResumeLayout(false);
            this.mrcInicio.PerformLayout();
            this.mrcExtra.ResumeLayout(false);
            this.mrcExtra.PerformLayout();
            this.mrcFin.ResumeLayout(false);
            this.mrcFijos.ResumeLayout(false);
            this.mrcFijos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.GroupBox mrcInicio;
        private System.Windows.Forms.GroupBox mrcFijos;
        private System.Windows.Forms.GroupBox mrcExtra;
        private System.Windows.Forms.TextBox txtSobrante;
        private System.Windows.Forms.Label lblSaldoSobrante;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Label lblGastosExtras;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.GroupBox mrcFin;
    }
}

