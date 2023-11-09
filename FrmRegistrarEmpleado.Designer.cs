namespace WF_MiniMarket
{
    partial class FrmRegistrarEmpleado
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
            this.txtBoxRegistrarClaveEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBoxRegistrarTipoDocumentoEmpleado = new System.Windows.Forms.ComboBox();
            this.btnGuardarEmpleado = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxRegistrarNDocumentoEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxRegistrarCelularEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxRegistrarCorreoEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxRegistrarApellidosEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxRegistrarNombresEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbRegistrarEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistrarEmpleado
            // 
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxRegistrarClaveEmpleado);
            this.gbRegistrarEmpleado.Controls.Add(this.label6);
            this.gbRegistrarEmpleado.Controls.Add(this.cbBoxRegistrarTipoDocumentoEmpleado);
            this.gbRegistrarEmpleado.Controls.Add(this.btnGuardarEmpleado);
            this.gbRegistrarEmpleado.Controls.Add(this.label8);
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxRegistrarNDocumentoEmpleado);
            this.gbRegistrarEmpleado.Controls.Add(this.label5);
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxRegistrarCelularEmpleado);
            this.gbRegistrarEmpleado.Controls.Add(this.label3);
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxRegistrarCorreoEmpleado);
            this.gbRegistrarEmpleado.Controls.Add(this.label4);
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxRegistrarApellidosEmpleado);
            this.gbRegistrarEmpleado.Controls.Add(this.label2);
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxRegistrarNombresEmpleado);
            this.gbRegistrarEmpleado.Controls.Add(this.label1);
            this.gbRegistrarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistrarEmpleado.Location = new System.Drawing.Point(12, 12);
            this.gbRegistrarEmpleado.Name = "gbRegistrarEmpleado";
            this.gbRegistrarEmpleado.Size = new System.Drawing.Size(776, 426);
            this.gbRegistrarEmpleado.TabIndex = 2;
            this.gbRegistrarEmpleado.TabStop = false;
            this.gbRegistrarEmpleado.Text = "Registrar de Empleado";
            // 
            // txtBoxRegistrarClaveEmpleado
            // 
            this.txtBoxRegistrarClaveEmpleado.Location = new System.Drawing.Point(90, 278);
            this.txtBoxRegistrarClaveEmpleado.Name = "txtBoxRegistrarClaveEmpleado";
            this.txtBoxRegistrarClaveEmpleado.Size = new System.Drawing.Size(247, 22);
            this.txtBoxRegistrarClaveEmpleado.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Clave:";
            // 
            // cbBoxRegistrarTipoDocumentoEmpleado
            // 
            this.cbBoxRegistrarTipoDocumentoEmpleado.FormattingEnabled = true;
            this.cbBoxRegistrarTipoDocumentoEmpleado.Items.AddRange(new object[] {
            "CC",
            "TI",
            "PAS",
            "PEP",
            "PPT",
            "CE",
            "Otro"});
            this.cbBoxRegistrarTipoDocumentoEmpleado.Location = new System.Drawing.Point(498, 46);
            this.cbBoxRegistrarTipoDocumentoEmpleado.Name = "cbBoxRegistrarTipoDocumentoEmpleado";
            this.cbBoxRegistrarTipoDocumentoEmpleado.Size = new System.Drawing.Size(231, 24);
            this.cbBoxRegistrarTipoDocumentoEmpleado.TabIndex = 24;
            this.cbBoxRegistrarTipoDocumentoEmpleado.Text = "Seleccione...";
            // 
            // btnGuardarEmpleado
            // 
            this.btnGuardarEmpleado.Location = new System.Drawing.Point(36, 340);
            this.btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            this.btnGuardarEmpleado.Size = new System.Drawing.Size(84, 32);
            this.btnGuardarEmpleado.TabIndex = 18;
            this.btnGuardarEmpleado.Text = "Guardar";
            this.btnGuardarEmpleado.UseVisualStyleBackColor = true;
            this.btnGuardarEmpleado.Click += new System.EventHandler(this.btnGuardarEmpleado_Click);
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
            // txtBoxRegistrarNDocumentoEmpleado
            // 
            this.txtBoxRegistrarNDocumentoEmpleado.Location = new System.Drawing.Point(147, 48);
            this.txtBoxRegistrarNDocumentoEmpleado.Name = "txtBoxRegistrarNDocumentoEmpleado";
            this.txtBoxRegistrarNDocumentoEmpleado.Size = new System.Drawing.Size(197, 22);
            this.txtBoxRegistrarNDocumentoEmpleado.TabIndex = 11;
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
            // txtBoxRegistrarCelularEmpleado
            // 
            this.txtBoxRegistrarCelularEmpleado.Location = new System.Drawing.Point(430, 210);
            this.txtBoxRegistrarCelularEmpleado.Name = "txtBoxRegistrarCelularEmpleado";
            this.txtBoxRegistrarCelularEmpleado.Size = new System.Drawing.Size(299, 22);
            this.txtBoxRegistrarCelularEmpleado.TabIndex = 7;
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
            // txtBoxRegistrarCorreoEmpleado
            // 
            this.txtBoxRegistrarCorreoEmpleado.Location = new System.Drawing.Point(97, 210);
            this.txtBoxRegistrarCorreoEmpleado.Name = "txtBoxRegistrarCorreoEmpleado";
            this.txtBoxRegistrarCorreoEmpleado.Size = new System.Drawing.Size(247, 22);
            this.txtBoxRegistrarCorreoEmpleado.TabIndex = 5;
            this.txtBoxRegistrarCorreoEmpleado.TextChanged += new System.EventHandler(this.txtBoxActualizarTelefono_TextChanged);
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
            // txtBoxRegistrarApellidosEmpleado
            // 
            this.txtBoxRegistrarApellidosEmpleado.Location = new System.Drawing.Point(450, 132);
            this.txtBoxRegistrarApellidosEmpleado.Name = "txtBoxRegistrarApellidosEmpleado";
            this.txtBoxRegistrarApellidosEmpleado.Size = new System.Drawing.Size(279, 22);
            this.txtBoxRegistrarApellidosEmpleado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos:";
            // 
            // txtBoxRegistrarNombresEmpleado
            // 
            this.txtBoxRegistrarNombresEmpleado.Location = new System.Drawing.Point(113, 132);
            this.txtBoxRegistrarNombresEmpleado.Name = "txtBoxRegistrarNombresEmpleado";
            this.txtBoxRegistrarNombresEmpleado.Size = new System.Drawing.Size(231, 22);
            this.txtBoxRegistrarNombresEmpleado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // FrmRegistrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbRegistrarEmpleado);
            this.Name = "FrmRegistrarEmpleado";
            this.Text = "FrmRegistrarEmpleado";
            this.gbRegistrarEmpleado.ResumeLayout(false);
            this.gbRegistrarEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistrarEmpleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxRegistrarNDocumentoEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxRegistrarCorreoEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxRegistrarApellidosEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxRegistrarNombresEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxRegistrarCelularEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardarEmpleado;
        private System.Windows.Forms.TextBox txtBoxRegistrarClaveEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBoxRegistrarTipoDocumentoEmpleado;
    }
}