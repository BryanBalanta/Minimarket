namespace WF_MiniMarket
{
    partial class FrmRegistrarProducto
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
            this.cbBoxRegistrarUnidadMedidaProducto = new System.Windows.Forms.ComboBox();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.txtBoxRegistrarDescripcionProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxRegistrarPrecioVentaPublicoProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxRegistrarStockProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxRegistrarMarcaProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxRegistrarNombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbRegistrarProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistrarProducto
            // 
            this.gbRegistrarProducto.Controls.Add(this.cbBoxRegistrarUnidadMedidaProducto);
            this.gbRegistrarProducto.Controls.Add(this.btnGuardarProducto);
            this.gbRegistrarProducto.Controls.Add(this.txtBoxRegistrarDescripcionProducto);
            this.gbRegistrarProducto.Controls.Add(this.label9);
            this.gbRegistrarProducto.Controls.Add(this.txtBoxRegistrarPrecioVentaPublicoProducto);
            this.gbRegistrarProducto.Controls.Add(this.label7);
            this.gbRegistrarProducto.Controls.Add(this.label5);
            this.gbRegistrarProducto.Controls.Add(this.txtBoxRegistrarStockProducto);
            this.gbRegistrarProducto.Controls.Add(this.label3);
            this.gbRegistrarProducto.Controls.Add(this.txtBoxRegistrarMarcaProducto);
            this.gbRegistrarProducto.Controls.Add(this.label4);
            this.gbRegistrarProducto.Controls.Add(this.txtBoxRegistrarNombreProducto);
            this.gbRegistrarProducto.Controls.Add(this.label1);
            this.gbRegistrarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistrarProducto.Location = new System.Drawing.Point(12, 12);
            this.gbRegistrarProducto.Name = "gbRegistrarProducto";
            this.gbRegistrarProducto.Size = new System.Drawing.Size(776, 426);
            this.gbRegistrarProducto.TabIndex = 3;
            this.gbRegistrarProducto.TabStop = false;
            this.gbRegistrarProducto.Text = "Registrar de Producto";
            this.gbRegistrarProducto.Enter += new System.EventHandler(this.gbRegistrarProducto_Enter);
            // 
            // cbBoxRegistrarUnidadMedidaProducto
            // 
            this.cbBoxRegistrarUnidadMedidaProducto.FormattingEnabled = true;
            this.cbBoxRegistrarUnidadMedidaProducto.Items.AddRange(new object[] {
            "UND",
            "gr"});
            this.cbBoxRegistrarUnidadMedidaProducto.Location = new System.Drawing.Point(490, 189);
            this.cbBoxRegistrarUnidadMedidaProducto.Name = "cbBoxRegistrarUnidadMedidaProducto";
            this.cbBoxRegistrarUnidadMedidaProducto.Size = new System.Drawing.Size(188, 24);
            this.cbBoxRegistrarUnidadMedidaProducto.TabIndex = 24;
            this.cbBoxRegistrarUnidadMedidaProducto.Text = "Seleccione...";
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Location = new System.Drawing.Point(36, 287);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(84, 32);
            this.btnGuardarProducto.TabIndex = 23;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // txtBoxRegistrarDescripcionProducto
            // 
            this.txtBoxRegistrarDescripcionProducto.Location = new System.Drawing.Point(141, 194);
            this.txtBoxRegistrarDescripcionProducto.Name = "txtBoxRegistrarDescripcionProducto";
            this.txtBoxRegistrarDescripcionProducto.Size = new System.Drawing.Size(203, 22);
            this.txtBoxRegistrarDescripcionProducto.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Descripcion:";
            // 
            // txtBoxRegistrarPrecioVentaPublicoProducto
            // 
            this.txtBoxRegistrarPrecioVentaPublicoProducto.Location = new System.Drawing.Point(527, 116);
            this.txtBoxRegistrarPrecioVentaPublicoProducto.Name = "txtBoxRegistrarPrecioVentaPublicoProducto";
            this.txtBoxRegistrarPrecioVentaPublicoProducto.Size = new System.Drawing.Size(151, 22);
            this.txtBoxRegistrarPrecioVentaPublicoProducto.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(367, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Precio venta Publico:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Unidad Medida:";
            // 
            // txtBoxRegistrarStockProducto
            // 
            this.txtBoxRegistrarStockProducto.Location = new System.Drawing.Point(89, 119);
            this.txtBoxRegistrarStockProducto.Name = "txtBoxRegistrarStockProducto";
            this.txtBoxRegistrarStockProducto.Size = new System.Drawing.Size(255, 22);
            this.txtBoxRegistrarStockProducto.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stock:";
            // 
            // txtBoxRegistrarMarcaProducto
            // 
            this.txtBoxRegistrarMarcaProducto.Location = new System.Drawing.Point(431, 43);
            this.txtBoxRegistrarMarcaProducto.Name = "txtBoxRegistrarMarcaProducto";
            this.txtBoxRegistrarMarcaProducto.Size = new System.Drawing.Size(247, 22);
            this.txtBoxRegistrarMarcaProducto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Marca:";
            // 
            // txtBoxRegistrarNombreProducto
            // 
            this.txtBoxRegistrarNombreProducto.Location = new System.Drawing.Point(105, 46);
            this.txtBoxRegistrarNombreProducto.Name = "txtBoxRegistrarNombreProducto";
            this.txtBoxRegistrarNombreProducto.Size = new System.Drawing.Size(239, 22);
            this.txtBoxRegistrarNombreProducto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // FrmRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbRegistrarProducto);
            this.Name = "FrmRegistrarProducto";
            this.Text = "FrmRegistrarProducto";
            this.gbRegistrarProducto.ResumeLayout(false);
            this.gbRegistrarProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistrarProducto;
        private System.Windows.Forms.TextBox txtBoxRegistrarPrecioVentaPublicoProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxRegistrarStockProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxRegistrarMarcaProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxRegistrarNombreProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxRegistrarDescripcionProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.ComboBox cbBoxRegistrarUnidadMedidaProducto;
    }
}