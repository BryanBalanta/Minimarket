namespace WF_MiniMarket
{
    partial class FrmRegistrarCliente
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
            this.gbRegistrarEmpleado = new System.Windows.Forms.GroupBox();
            this.cbBoxRegistrarTipoDocumentoCliente = new System.Windows.Forms.ComboBox();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxRegistrarNDocumentoCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxRegistrarCelularCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxRegistrarCorreoCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxRegistrarApellidosCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxRegistrarNombresCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbRegistrarEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistrarEmpleado
            // 
            this.gbRegistrarEmpleado.Controls.Add(this.cbBoxRegistrarTipoDocumentoCliente);
            this.gbRegistrarEmpleado.Controls.Add(this.btnGuardarCliente);
            this.gbRegistrarEmpleado.Controls.Add(this.label8);
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxRegistrarNDocumentoCliente);
            this.gbRegistrarEmpleado.Controls.Add(this.label5);
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxRegistrarCelularCliente);
            this.gbRegistrarEmpleado.Controls.Add(this.label3);
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxRegistrarCorreoCliente);
            this.gbRegistrarEmpleado.Controls.Add(this.label4);
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxRegistrarApellidosCliente);
            this.gbRegistrarEmpleado.Controls.Add(this.label2);
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxRegistrarNombresCliente);
            this.gbRegistrarEmpleado.Controls.Add(this.label1);
            this.gbRegistrarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistrarEmpleado.Location = new System.Drawing.Point(12, 12);
            this.gbRegistrarEmpleado.Name = "gbRegistrarEmpleado";
            this.gbRegistrarEmpleado.Size = new System.Drawing.Size(776, 426);
            this.gbRegistrarEmpleado.TabIndex = 3;
            this.gbRegistrarEmpleado.TabStop = false;
            this.gbRegistrarEmpleado.Text = "Registrar de Cliente";
            this.gbRegistrarEmpleado.Enter += new System.EventHandler(this.gbRegistrarEmpleado_Enter);
            // 
            // cbBoxRegistrarTipoDocumentoCliente
            // 
            this.cbBoxRegistrarTipoDocumentoCliente.FormattingEnabled = true;
            this.cbBoxRegistrarTipoDocumentoCliente.Items.AddRange(new object[] {
            "CC",
            "TI",
            "PAS",
            "PEP",
            "PPT",
            "CE",
            "Otro"});
            this.cbBoxRegistrarTipoDocumentoCliente.Location = new System.Drawing.Point(498, 43);
            this.cbBoxRegistrarTipoDocumentoCliente.Name = "cbBoxRegistrarTipoDocumentoCliente";
            this.cbBoxRegistrarTipoDocumentoCliente.Size = new System.Drawing.Size(231, 24);
            this.cbBoxRegistrarTipoDocumentoCliente.TabIndex = 23;
            this.cbBoxRegistrarTipoDocumentoCliente.Text = "Seleccione...";
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(36, 303);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(84, 32);
            this.btnGuardarCliente.TabIndex = 22;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(367, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tipo Documento:";
            // 
            // txtBoxRegistrarNDocumentoCliente
            // 
            this.txtBoxRegistrarNDocumentoCliente.Location = new System.Drawing.Point(147, 48);
            this.txtBoxRegistrarNDocumentoCliente.Name = "txtBoxRegistrarNDocumentoCliente";
            this.txtBoxRegistrarNDocumentoCliente.Size = new System.Drawing.Size(197, 22);
            this.txtBoxRegistrarNDocumentoCliente.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "N. Documento:";
            // 
            // txtBoxRegistrarCelularCliente
            // 
            this.txtBoxRegistrarCelularCliente.Location = new System.Drawing.Point(430, 210);
            this.txtBoxRegistrarCelularCliente.Name = "txtBoxRegistrarCelularCliente";
            this.txtBoxRegistrarCelularCliente.Size = new System.Drawing.Size(299, 22);
            this.txtBoxRegistrarCelularCliente.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Celular:";
            // 
            // txtBoxRegistrarCorreoCliente
            // 
            this.txtBoxRegistrarCorreoCliente.Location = new System.Drawing.Point(97, 210);
            this.txtBoxRegistrarCorreoCliente.Name = "txtBoxRegistrarCorreoCliente";
            this.txtBoxRegistrarCorreoCliente.Size = new System.Drawing.Size(247, 22);
            this.txtBoxRegistrarCorreoCliente.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Correo:";
            // 
            // txtBoxRegistrarApellidosCliente
            // 
            this.txtBoxRegistrarApellidosCliente.Location = new System.Drawing.Point(450, 126);
            this.txtBoxRegistrarApellidosCliente.Name = "txtBoxRegistrarApellidosCliente";
            this.txtBoxRegistrarApellidosCliente.Size = new System.Drawing.Size(279, 22);
            this.txtBoxRegistrarApellidosCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos:";
            // 
            // txtBoxRegistrarNombresCliente
            // 
            this.txtBoxRegistrarNombresCliente.Location = new System.Drawing.Point(113, 126);
            this.txtBoxRegistrarNombresCliente.Name = "txtBoxRegistrarNombresCliente";
            this.txtBoxRegistrarNombresCliente.Size = new System.Drawing.Size(231, 22);
            this.txtBoxRegistrarNombresCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // FrmRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbRegistrarEmpleado);
            this.Name = "FrmRegistrarCliente";
            this.Text = "FrmRegistrarCliente";
            this.gbRegistrarEmpleado.ResumeLayout(false);
            this.gbRegistrarEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistrarEmpleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxRegistrarNDocumentoCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxRegistrarCelularCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxRegistrarCorreoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxRegistrarApellidosCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxRegistrarNombresCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.ComboBox cbBoxRegistrarTipoDocumentoCliente;
    }
}