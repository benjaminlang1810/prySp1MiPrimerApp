﻿namespace PySp1MiPrimerApp
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
            this.mrcExtras = new System.Windows.Forms.GroupBox();
            this.txtGimnasio = new System.Windows.Forms.TextBox();
            this.lblSaldoSobrante = new System.Windows.Forms.Label();
            this.txtSalidas = new System.Windows.Forms.TextBox();
            this.lblSalidas = new System.Windows.Forms.Label();
            this.mrcFin = new System.Windows.Forms.GroupBox();
            this.txtSobrante = new System.Windows.Forms.TextBox();
            this.lblSobrante = new System.Windows.Forms.Label();
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
            this.mrcExtras.SuspendLayout();
            this.mrcFin.SuspendLayout();
            this.mrcFijos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIngresos
            // 
            this.txtIngresos.Location = new System.Drawing.Point(177, 13);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Size = new System.Drawing.Size(127, 21);
            this.txtIngresos.TabIndex = 1;
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.Location = new System.Drawing.Point(112, 15);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(59, 16);
            this.lblIngresos.TabIndex = 2;
            this.lblIngresos.Text = "Ingresos";
            // 
            // mrcInicio
            // 
            this.mrcInicio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mrcInicio.Controls.Add(this.mrcExtras);
            this.mrcInicio.Controls.Add(this.mrcFin);
            this.mrcInicio.Controls.Add(this.mrcFijos);
            this.mrcInicio.Controls.Add(this.lblIngresos);
            this.mrcInicio.Controls.Add(this.txtIngresos);
            this.mrcInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcInicio.Location = new System.Drawing.Point(0, -3);
            this.mrcInicio.Name = "mrcInicio";
            this.mrcInicio.Size = new System.Drawing.Size(428, 361);
            this.mrcInicio.TabIndex = 3;
            this.mrcInicio.TabStop = false;
            this.mrcInicio.Text = "Inicio";
            // 
            // mrcExtras
            // 
            this.mrcExtras.Controls.Add(this.txtGimnasio);
            this.mrcExtras.Controls.Add(this.lblSaldoSobrante);
            this.mrcExtras.Controls.Add(this.txtSalidas);
            this.mrcExtras.Controls.Add(this.lblSalidas);
            this.mrcExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcExtras.Location = new System.Drawing.Point(60, 178);
            this.mrcExtras.Name = "mrcExtras";
            this.mrcExtras.Size = new System.Drawing.Size(280, 79);
            this.mrcExtras.TabIndex = 9;
            this.mrcExtras.TabStop = false;
            this.mrcExtras.Text = "Gastos Extras";
            // 
            // txtGimnasio
            // 
            this.txtGimnasio.Location = new System.Drawing.Point(105, 50);
            this.txtGimnasio.Name = "txtGimnasio";
            this.txtGimnasio.Size = new System.Drawing.Size(100, 21);
            this.txtGimnasio.TabIndex = 3;
            // 
            // lblSaldoSobrante
            // 
            this.lblSaldoSobrante.AutoSize = true;
            this.lblSaldoSobrante.Location = new System.Drawing.Point(6, 53);
            this.lblSaldoSobrante.Name = "lblSaldoSobrante";
            this.lblSaldoSobrante.Size = new System.Drawing.Size(60, 15);
            this.lblSaldoSobrante.TabIndex = 2;
            this.lblSaldoSobrante.Text = "Gimnasio";
            // 
            // txtSalidas
            // 
            this.txtSalidas.Location = new System.Drawing.Point(105, 24);
            this.txtSalidas.Name = "txtSalidas";
            this.txtSalidas.Size = new System.Drawing.Size(100, 21);
            this.txtSalidas.TabIndex = 1;
            // 
            // lblSalidas
            // 
            this.lblSalidas.AutoSize = true;
            this.lblSalidas.Location = new System.Drawing.Point(6, 27);
            this.lblSalidas.Name = "lblSalidas";
            this.lblSalidas.Size = new System.Drawing.Size(48, 15);
            this.lblSalidas.TabIndex = 0;
            this.lblSalidas.Text = "Salidas";
            // 
            // mrcFin
            // 
            this.mrcFin.Controls.Add(this.txtSobrante);
            this.mrcFin.Controls.Add(this.lblSobrante);
            this.mrcFin.Controls.Add(this.cmdGrabar);
            this.mrcFin.Controls.Add(this.cmdCancelar);
            this.mrcFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcFin.Location = new System.Drawing.Point(60, 263);
            this.mrcFin.Name = "mrcFin";
            this.mrcFin.Size = new System.Drawing.Size(332, 83);
            this.mrcFin.TabIndex = 11;
            this.mrcFin.TabStop = false;
            this.mrcFin.Text = "Fin";
            // 
            // txtSobrante
            // 
            this.txtSobrante.Location = new System.Drawing.Point(169, 57);
            this.txtSobrante.Name = "txtSobrante";
            this.txtSobrante.Size = new System.Drawing.Size(75, 21);
            this.txtSobrante.TabIndex = 12;
            this.txtSobrante.TextChanged += new System.EventHandler(this.txtSobrante_TextChanged);
            // 
            // lblSobrante
            // 
            this.lblSobrante.AutoSize = true;
            this.lblSobrante.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrante.Location = new System.Drawing.Point(63, 59);
            this.lblSobrante.Name = "lblSobrante";
            this.lblSobrante.Size = new System.Drawing.Size(100, 16);
            this.lblSobrante.TabIndex = 12;
            this.lblSobrante.Text = "Saldo Sobrante";
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.BackColor = System.Drawing.SystemColors.Info;
            this.cmdGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGrabar.Location = new System.Drawing.Point(22, 16);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(108, 29);
            this.cmdGrabar.TabIndex = 10;
            this.cmdGrabar.Text = "Calcular";
            this.cmdGrabar.UseVisualStyleBackColor = false;
            this.cmdGrabar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.AccessibleDescription = "";
            this.cmdCancelar.BackColor = System.Drawing.SystemColors.Info;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(196, 16);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(116, 29);
            this.cmdCancelar.TabIndex = 9;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // mrcFijos
            // 
            this.mrcFijos.Controls.Add(this.txtComida);
            this.mrcFijos.Controls.Add(this.txtImpuestos);
            this.mrcFijos.Controls.Add(this.lblComida);
            this.mrcFijos.Controls.Add(this.lblImpuestos);
            this.mrcFijos.Controls.Add(this.txtAlquiler);
            this.mrcFijos.Controls.Add(this.lblAlquiler);
            this.mrcFijos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtComida.Size = new System.Drawing.Size(100, 21);
            this.txtComida.TabIndex = 8;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Location = new System.Drawing.Point(64, 53);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(100, 21);
            this.txtImpuestos.TabIndex = 7;
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Location = new System.Drawing.Point(2, 82);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(50, 15);
            this.lblComida.TabIndex = 6;
            this.lblComida.Text = "Comida";
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Location = new System.Drawing.Point(3, 53);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(64, 15);
            this.lblImpuestos.TabIndex = 5;
            this.lblImpuestos.Text = "Impuestos";
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Location = new System.Drawing.Point(64, 21);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(100, 21);
            this.txtAlquiler.TabIndex = 4;
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AccessibleName = "";
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Location = new System.Drawing.Point(3, 24);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(48, 15);
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
            this.mrcExtras.ResumeLayout(false);
            this.mrcExtras.PerformLayout();
            this.mrcFin.ResumeLayout(false);
            this.mrcFin.PerformLayout();
            this.mrcFijos.ResumeLayout(false);
            this.mrcFijos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.GroupBox mrcInicio;
        private System.Windows.Forms.GroupBox mrcFijos;
        private System.Windows.Forms.GroupBox mrcExtras;
        private System.Windows.Forms.TextBox txtGimnasio;
        private System.Windows.Forms.Label lblSaldoSobrante;
        private System.Windows.Forms.TextBox txtSalidas;
        private System.Windows.Forms.Label lblSalidas;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.GroupBox mrcFin;
        private System.Windows.Forms.Label lblSobrante;
        private System.Windows.Forms.TextBox txtSobrante;
    }
}

