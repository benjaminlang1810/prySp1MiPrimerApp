namespace PySp1MiPrimerApp
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
            this.cmdComprasSuper = new System.Windows.Forms.Button();
            this.cmdGestionDeGastos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdComprasSuper
            // 
            this.cmdComprasSuper.BackgroundImage = global::PySp1MiPrimerApp.Properties.Resources.COMPRAS_SUPERMERCADO2;
            this.cmdComprasSuper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdComprasSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComprasSuper.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdComprasSuper.Location = new System.Drawing.Point(54, 12);
            this.cmdComprasSuper.Name = "cmdComprasSuper";
            this.cmdComprasSuper.Size = new System.Drawing.Size(377, 128);
            this.cmdComprasSuper.TabIndex = 0;
            this.cmdComprasSuper.Text = "Compras Super";
            this.cmdComprasSuper.UseVisualStyleBackColor = true;
            this.cmdComprasSuper.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdGestionDeGastos
            // 
            this.cmdGestionDeGastos.BackgroundImage = global::PySp1MiPrimerApp.Properties.Resources.billetera_con_dinero;
            this.cmdGestionDeGastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdGestionDeGastos.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGestionDeGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGestionDeGastos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdGestionDeGastos.Location = new System.Drawing.Point(54, 146);
            this.cmdGestionDeGastos.Name = "cmdGestionDeGastos";
            this.cmdGestionDeGastos.Size = new System.Drawing.Size(377, 120);
            this.cmdGestionDeGastos.TabIndex = 2;
            this.cmdGestionDeGastos.Text = "Gestion de Gastos";
            this.cmdGestionDeGastos.UseVisualStyleBackColor = true;
            this.cmdGestionDeGastos.Click += new System.EventHandler(this.cmdGestionDeGastos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(494, 321);
            this.Controls.Add(this.cmdGestionDeGastos);
            this.Controls.Add(this.cmdComprasSuper);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdComprasSuper;
        private System.Windows.Forms.Button cmdGestionDeGastos;
    }
}