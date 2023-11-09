namespace WF_MiniMarket
{
    partial class FrmRegistrarFactura
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
            this.gbRegistrarProducto = new System.Windows.Forms.GroupBox();
            this.btnGuardarFactura = new System.Windows.Forms.Button();
            this.txtBoxRegistrarTotalFactura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxRegistrarSinIvaFactura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxRegistrarIvaFactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxRegistrarCodigoFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxRegistrarFechaGeneracionFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbRegistrarProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistrarProducto
            // 
            this.gbRegistrarProducto.Controls.Add(this.btnGuardarFactura);
            this.gbRegistrarProducto.Controls.Add(this.txtBoxRegistrarTotalFactura);
            this.gbRegistrarProducto.Controls.Add(this.label7);
            this.gbRegistrarProducto.Controls.Add(this.txtBoxRegistrarSinIvaFactura);
            this.gbRegistrarProducto.Controls.Add(this.label3);
            this.gbRegistrarProducto.Controls.Add(this.txtBoxRegistrarIvaFactura);
            this.gbRegistrarProducto.Controls.Add(this.label4);
            this.gbRegistrarProducto.Controls.Add(this.txtBoxRegistrarCodigoFactura);
            this.gbRegistrarProducto.Controls.Add(this.label2);
            this.gbRegistrarProducto.Controls.Add(this.txtBoxRegistrarFechaGeneracionFactura);
            this.gbRegistrarProducto.Controls.Add(this.label1);
            this.gbRegistrarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistrarProducto.Location = new System.Drawing.Point(12, 12);
            this.gbRegistrarProducto.Name = "gbRegistrarProducto";
            this.gbRegistrarProducto.Size = new System.Drawing.Size(776, 426);
            this.gbRegistrarProducto.TabIndex = 4;
            this.gbRegistrarProducto.TabStop = false;
            this.gbRegistrarProducto.Text = "Registrar de Factura";
            // 
            // btnGuardarFactura
            // 
            this.btnGuardarFactura.Location = new System.Drawing.Point(36, 312);
            this.btnGuardarFactura.Name = "btnGuardarFactura";
            this.btnGuardarFactura.Size = new System.Drawing.Size(84, 32);
            this.btnGuardarFactura.TabIndex = 23;
            this.btnGuardarFactura.Text = "Guardar";
            this.btnGuardarFactura.UseVisualStyleBackColor = true;
            this.btnGuardarFactura.Click += new System.EventHandler(this.btnGuardarFactura_Click);
            // 
            // txtBoxRegistrarTotalFactura
            // 
            this.txtBoxRegistrarTotalFactura.Location = new System.Drawing.Point(86, 194);
            this.txtBoxRegistrarTotalFactura.Name = "txtBoxRegistrarTotalFactura";
            this.txtBoxRegistrarTotalFactura.Size = new System.Drawing.Size(258, 22);
            this.txtBoxRegistrarTotalFactura.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total:";
            // 
            // txtBoxRegistrarSinIvaFactura
            // 
            this.txtBoxRegistrarSinIvaFactura.Location = new System.Drawing.Point(431, 120);
            this.txtBoxRegistrarSinIvaFactura.Name = "txtBoxRegistrarSinIvaFactura";
            this.txtBoxRegistrarSinIvaFactura.Size = new System.Drawing.Size(255, 22);
            this.txtBoxRegistrarSinIvaFactura.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sin Iva:";
            // 
            // txtBoxRegistrarIvaFactura
            // 
            this.txtBoxRegistrarIvaFactura.Location = new System.Drawing.Point(71, 120);
            this.txtBoxRegistrarIvaFactura.Name = "txtBoxRegistrarIvaFactura";
            this.txtBoxRegistrarIvaFactura.Size = new System.Drawing.Size(273, 22);
            this.txtBoxRegistrarIvaFactura.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Iva:";
            // 
            // txtBoxRegistrarCodigoFactura
            // 
            this.txtBoxRegistrarCodigoFactura.Location = new System.Drawing.Point(100, 45);
            this.txtBoxRegistrarCodigoFactura.Name = "txtBoxRegistrarCodigoFactura";
            this.txtBoxRegistrarCodigoFactura.Size = new System.Drawing.Size(244, 22);
            this.txtBoxRegistrarCodigoFactura.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo:";
            // 
            // txtBoxRegistrarFechaGeneracionFactura
            // 
            this.txtBoxRegistrarFechaGeneracionFactura.Location = new System.Drawing.Point(511, 45);
            this.txtBoxRegistrarFechaGeneracionFactura.Name = "txtBoxRegistrarFechaGeneracionFactura";
            this.txtBoxRegistrarFechaGeneracionFactura.Size = new System.Drawing.Size(167, 22);
            this.txtBoxRegistrarFechaGeneracionFactura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Generacion:";
            // 
            // FrmRegistrarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbRegistrarProducto);
            this.Name = "FrmRegistrarFactura";
            this.Text = "FrmRegistrarFactura";
            this.gbRegistrarProducto.ResumeLayout(false);
            this.gbRegistrarProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistrarProducto;
        private System.Windows.Forms.Button btnGuardarFactura;
        private System.Windows.Forms.TextBox txtBoxRegistrarTotalFactura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxRegistrarSinIvaFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxRegistrarIvaFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxRegistrarCodigoFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxRegistrarFechaGeneracionFactura;
        private System.Windows.Forms.Label label1;
    }
}