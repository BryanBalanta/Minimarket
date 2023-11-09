namespace WF_MiniMarket
{
    partial class FrmConsultarProveedor
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
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.gbActualizarProveedor = new System.Windows.Forms.GroupBox();
            this.txtBoxActualizarDepartamentoProveedor = new System.Windows.Forms.TextBox();
            this.txtBoxActualizarCiudadProveedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxActualizarCorreoProveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxActualizarNomenclaturaProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnActualizarProveedor = new System.Windows.Forms.Button();
            this.txtBoxActualizarTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxActualizarRazonSocialProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxActualizarNitProveedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbGestionProveedores = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.gbActualizarProveedor.SuspendLayout();
            this.gbGestionProveedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(6, 19);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.Size = new System.Drawing.Size(764, 160);
            this.dgvProveedores.TabIndex = 0;
            this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentClick);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProveedor.Location = new System.Drawing.Point(660, 406);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(84, 32);
            this.btnAgregarProveedor.TabIndex = 19;
            this.btnAgregarProveedor.Text = "Agregar";
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnActualizarCategoria_Click);
            // 
            // gbActualizarProveedor
            // 
            this.gbActualizarProveedor.Controls.Add(this.txtBoxActualizarDepartamentoProveedor);
            this.gbActualizarProveedor.Controls.Add(this.txtBoxActualizarCiudadProveedor);
            this.gbActualizarProveedor.Controls.Add(this.label7);
            this.gbActualizarProveedor.Controls.Add(this.txtBoxActualizarCorreoProveedor);
            this.gbActualizarProveedor.Controls.Add(this.label5);
            this.gbActualizarProveedor.Controls.Add(this.label6);
            this.gbActualizarProveedor.Controls.Add(this.txtBoxActualizarNomenclaturaProveedor);
            this.gbActualizarProveedor.Controls.Add(this.label3);
            this.gbActualizarProveedor.Controls.Add(this.btnActualizarProveedor);
            this.gbActualizarProveedor.Controls.Add(this.txtBoxActualizarTelefonoProveedor);
            this.gbActualizarProveedor.Controls.Add(this.label4);
            this.gbActualizarProveedor.Controls.Add(this.txtBoxActualizarRazonSocialProveedor);
            this.gbActualizarProveedor.Controls.Add(this.label2);
            this.gbActualizarProveedor.Controls.Add(this.txtBoxActualizarNitProveedor);
            this.gbActualizarProveedor.Controls.Add(this.label8);
            this.gbActualizarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActualizarProveedor.Location = new System.Drawing.Point(12, 203);
            this.gbActualizarProveedor.Name = "gbActualizarProveedor";
            this.gbActualizarProveedor.Size = new System.Drawing.Size(776, 197);
            this.gbActualizarProveedor.TabIndex = 20;
            this.gbActualizarProveedor.TabStop = false;
            this.gbActualizarProveedor.Text = "Actualizar de Proveedor";
            // 
            // txtBoxActualizarDepartamentoProveedor
            // 
            this.txtBoxActualizarDepartamentoProveedor.Location = new System.Drawing.Point(482, 97);
            this.txtBoxActualizarDepartamentoProveedor.Name = "txtBoxActualizarDepartamentoProveedor";
            this.txtBoxActualizarDepartamentoProveedor.Size = new System.Drawing.Size(250, 22);
            this.txtBoxActualizarDepartamentoProveedor.TabIndex = 30;
            // 
            // txtBoxActualizarCiudadProveedor
            // 
            this.txtBoxActualizarCiudadProveedor.Location = new System.Drawing.Point(97, 97);
            this.txtBoxActualizarCiudadProveedor.Name = "txtBoxActualizarCiudadProveedor";
            this.txtBoxActualizarCiudadProveedor.Size = new System.Drawing.Size(247, 22);
            this.txtBoxActualizarCiudadProveedor.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Ciudad:";
            // 
            // txtBoxActualizarCorreoProveedor
            // 
            this.txtBoxActualizarCorreoProveedor.Location = new System.Drawing.Point(97, 126);
            this.txtBoxActualizarCorreoProveedor.Name = "txtBoxActualizarCorreoProveedor";
            this.txtBoxActualizarCorreoProveedor.Size = new System.Drawing.Size(247, 22);
            this.txtBoxActualizarCorreoProveedor.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Correo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(367, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Departamento:";
            // 
            // txtBoxActualizarNomenclaturaProveedor
            // 
            this.txtBoxActualizarNomenclaturaProveedor.Location = new System.Drawing.Point(476, 62);
            this.txtBoxActualizarNomenclaturaProveedor.Name = "txtBoxActualizarNomenclaturaProveedor";
            this.txtBoxActualizarNomenclaturaProveedor.Size = new System.Drawing.Size(256, 22);
            this.txtBoxActualizarNomenclaturaProveedor.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nomenclatura:";
            // 
            // btnActualizarProveedor
            // 
            this.btnActualizarProveedor.Location = new System.Drawing.Point(36, 154);
            this.btnActualizarProveedor.Name = "btnActualizarProveedor";
            this.btnActualizarProveedor.Size = new System.Drawing.Size(84, 32);
            this.btnActualizarProveedor.TabIndex = 17;
            this.btnActualizarProveedor.Text = "Actualizar";
            this.btnActualizarProveedor.UseVisualStyleBackColor = true;
            this.btnActualizarProveedor.Click += new System.EventHandler(this.btnActualizarProveedor_Click);
            // 
            // txtBoxActualizarTelefonoProveedor
            // 
            this.txtBoxActualizarTelefonoProveedor.Location = new System.Drawing.Point(112, 65);
            this.txtBoxActualizarTelefonoProveedor.Name = "txtBoxActualizarTelefonoProveedor";
            this.txtBoxActualizarTelefonoProveedor.Size = new System.Drawing.Size(232, 22);
            this.txtBoxActualizarTelefonoProveedor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefono:";
            // 
            // txtBoxActualizarRazonSocialProveedor
            // 
            this.txtBoxActualizarRazonSocialProveedor.Location = new System.Drawing.Point(476, 35);
            this.txtBoxActualizarRazonSocialProveedor.Name = "txtBoxActualizarRazonSocialProveedor";
            this.txtBoxActualizarRazonSocialProveedor.Size = new System.Drawing.Size(256, 22);
            this.txtBoxActualizarRazonSocialProveedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Razon Social:";
            // 
            // txtBoxActualizarNitProveedor
            // 
            this.txtBoxActualizarNitProveedor.Location = new System.Drawing.Point(75, 35);
            this.txtBoxActualizarNitProveedor.Name = "txtBoxActualizarNitProveedor";
            this.txtBoxActualizarNitProveedor.Size = new System.Drawing.Size(269, 22);
            this.txtBoxActualizarNitProveedor.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "NIT:";
            // 
            // gbGestionProveedores
            // 
            this.gbGestionProveedores.Controls.Add(this.dgvProveedores);
            this.gbGestionProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGestionProveedores.Location = new System.Drawing.Point(12, 12);
            this.gbGestionProveedores.Name = "gbGestionProveedores";
            this.gbGestionProveedores.Size = new System.Drawing.Size(776, 185);
            this.gbGestionProveedores.TabIndex = 21;
            this.gbGestionProveedores.TabStop = false;
            this.gbGestionProveedores.Text = "Gestion Proveedores";
            this.gbGestionProveedores.Enter += new System.EventHandler(this.gbGestionProveedores_Enter);
            // 
            // FrmConsultarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbGestionProveedores);
            this.Controls.Add(this.gbActualizarProveedor);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Name = "FrmConsultarProveedor";
            this.Text = "FrmConsultarProveedor";
            this.Load += new System.EventHandler(this.FrmConsultarProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.gbActualizarProveedor.ResumeLayout(false);
            this.gbActualizarProveedor.PerformLayout();
            this.gbGestionProveedores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.GroupBox gbActualizarProveedor;
        private System.Windows.Forms.TextBox txtBoxActualizarDepartamentoProveedor;
        private System.Windows.Forms.TextBox txtBoxActualizarCiudadProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxActualizarCorreoProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxActualizarNomenclaturaProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnActualizarProveedor;
        private System.Windows.Forms.TextBox txtBoxActualizarTelefonoProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxActualizarRazonSocialProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxActualizarNitProveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbGestionProveedores;
    }
}