﻿namespace WF_MiniMarket
{
    partial class FrmConsultarCliente
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
            this.gbGestionCliente = new System.Windows.Forms.GroupBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.gbRegistrarEmpleado = new System.Windows.Forms.GroupBox();
            this.cbBoxActualizarTipoDocumentoCliente = new System.Windows.Forms.ComboBox();
            this.btnActualizarCliente = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxActualizarNDocumentoCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxActulizarCelularCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxActualizarCorreoCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxActualizarApellidosCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxActualizarNombresCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.gbGestionCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.gbRegistrarEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGestionCliente
            // 
            this.gbGestionCliente.Controls.Add(this.dgvCliente);
            this.gbGestionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGestionCliente.Location = new System.Drawing.Point(12, 12);
            this.gbGestionCliente.Name = "gbGestionCliente";
            this.gbGestionCliente.Size = new System.Drawing.Size(776, 182);
            this.gbGestionCliente.TabIndex = 22;
            this.gbGestionCliente.TabStop = false;
            this.gbGestionCliente.Text = "Gestion Cliente";
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(6, 19);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(764, 156);
            this.dgvCliente.TabIndex = 0;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // gbRegistrarEmpleado
            // 
            this.gbRegistrarEmpleado.Controls.Add(this.cbBoxActualizarTipoDocumentoCliente);
            this.gbRegistrarEmpleado.Controls.Add(this.btnActualizarCliente);
            this.gbRegistrarEmpleado.Controls.Add(this.label8);
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxActualizarNDocumentoCliente);
            this.gbRegistrarEmpleado.Controls.Add(this.label5);
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxActulizarCelularCliente);
            this.gbRegistrarEmpleado.Controls.Add(this.label3);
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxActualizarCorreoCliente);
            this.gbRegistrarEmpleado.Controls.Add(this.label4);
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxActualizarApellidosCliente);
            this.gbRegistrarEmpleado.Controls.Add(this.label2);
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxActualizarNombresCliente);
            this.gbRegistrarEmpleado.Controls.Add(this.label1);
            this.gbRegistrarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistrarEmpleado.Location = new System.Drawing.Point(12, 200);
            this.gbRegistrarEmpleado.Name = "gbRegistrarEmpleado";
            this.gbRegistrarEmpleado.Size = new System.Drawing.Size(776, 200);
            this.gbRegistrarEmpleado.TabIndex = 23;
            this.gbRegistrarEmpleado.TabStop = false;
            this.gbRegistrarEmpleado.Text = "Actualizar de Cliente";
            // 
            // cbBoxActualizarTipoDocumentoCliente
            // 
            this.cbBoxActualizarTipoDocumentoCliente.FormattingEnabled = true;
            this.cbBoxActualizarTipoDocumentoCliente.Items.AddRange(new object[] {
            "CC",
            "TI",
            "PAS",
            "PEP",
            "PPT",
            "CE",
            "Otro"});
            this.cbBoxActualizarTipoDocumentoCliente.Location = new System.Drawing.Point(498, 23);
            this.cbBoxActualizarTipoDocumentoCliente.Name = "cbBoxActualizarTipoDocumentoCliente";
            this.cbBoxActualizarTipoDocumentoCliente.Size = new System.Drawing.Size(231, 24);
            this.cbBoxActualizarTipoDocumentoCliente.TabIndex = 24;
            this.cbBoxActualizarTipoDocumentoCliente.Text = "Seleccione...";
            // 
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.Location = new System.Drawing.Point(36, 159);
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.Size = new System.Drawing.Size(84, 32);
            this.btnActualizarCliente.TabIndex = 18;
            this.btnActualizarCliente.Text = "Actualizar";
            this.btnActualizarCliente.UseVisualStyleBackColor = true;
            this.btnActualizarCliente.Click += new System.EventHandler(this.btnActualizarCliente_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(367, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tipo Documento:";
            // 
            // txtBoxActualizarNDocumentoCliente
            // 
            this.txtBoxActualizarNDocumentoCliente.Location = new System.Drawing.Point(147, 28);
            this.txtBoxActualizarNDocumentoCliente.Name = "txtBoxActualizarNDocumentoCliente";
            this.txtBoxActualizarNDocumentoCliente.Size = new System.Drawing.Size(197, 22);
            this.txtBoxActualizarNDocumentoCliente.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "N. Documento:";
            // 
            // txtBoxActulizarCelularCliente
            // 
            this.txtBoxActulizarCelularCliente.Location = new System.Drawing.Point(430, 110);
            this.txtBoxActulizarCelularCliente.Name = "txtBoxActulizarCelularCliente";
            this.txtBoxActulizarCelularCliente.Size = new System.Drawing.Size(299, 22);
            this.txtBoxActulizarCelularCliente.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Celular:";
            // 
            // txtBoxActualizarCorreoCliente
            // 
            this.txtBoxActualizarCorreoCliente.Location = new System.Drawing.Point(97, 110);
            this.txtBoxActualizarCorreoCliente.Name = "txtBoxActualizarCorreoCliente";
            this.txtBoxActualizarCorreoCliente.Size = new System.Drawing.Size(247, 22);
            this.txtBoxActualizarCorreoCliente.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Correo:";
            // 
            // txtBoxActualizarApellidosCliente
            // 
            this.txtBoxActualizarApellidosCliente.Location = new System.Drawing.Point(450, 69);
            this.txtBoxActualizarApellidosCliente.Name = "txtBoxActualizarApellidosCliente";
            this.txtBoxActualizarApellidosCliente.Size = new System.Drawing.Size(279, 22);
            this.txtBoxActualizarApellidosCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos:";
            // 
            // txtBoxActualizarNombresCliente
            // 
            this.txtBoxActualizarNombresCliente.Location = new System.Drawing.Point(113, 69);
            this.txtBoxActualizarNombresCliente.Name = "txtBoxActualizarNombresCliente";
            this.txtBoxActualizarNombresCliente.Size = new System.Drawing.Size(231, 22);
            this.txtBoxActualizarNombresCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.Location = new System.Drawing.Point(657, 406);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(84, 32);
            this.btnAgregarCliente.TabIndex = 24;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // FrmConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.gbRegistrarEmpleado);
            this.Controls.Add(this.gbGestionCliente);
            this.Name = "FrmConsultarCliente";
            this.Text = "FrmConsultarCliente";
            this.Load += new System.EventHandler(this.FrmConsultarCliente_Load);
            this.gbGestionCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.gbRegistrarEmpleado.ResumeLayout(false);
            this.gbRegistrarEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGestionCliente;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.GroupBox gbRegistrarEmpleado;
        private System.Windows.Forms.ComboBox cbBoxActualizarTipoDocumentoCliente;
        private System.Windows.Forms.Button btnActualizarCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxActualizarNDocumentoCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxActulizarCelularCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxActualizarCorreoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxActualizarApellidosCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxActualizarNombresCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarCliente;
    }
}