namespace WF_MiniMarket
{
    partial class FrmConsultarCategoria
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
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.gbRegistrarEmpleado = new System.Windows.Forms.GroupBox();
            this.btnActualizarCategoria = new System.Windows.Forms.Button();
            this.txtBoxActualizarDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxActualizarNombreCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.gbGestionCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.gbRegistrarEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGestionCliente
            // 
            this.gbGestionCliente.Controls.Add(this.dgvCategoria);
            this.gbGestionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGestionCliente.Location = new System.Drawing.Point(12, 12);
            this.gbGestionCliente.Name = "gbGestionCliente";
            this.gbGestionCliente.Size = new System.Drawing.Size(776, 182);
            this.gbGestionCliente.TabIndex = 23;
            this.gbGestionCliente.TabStop = false;
            this.gbGestionCliente.Text = "Gestion Categoria";
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(6, 19);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.Size = new System.Drawing.Size(764, 156);
            this.dgvCategoria.TabIndex = 0;
            this.dgvCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellContentClick);
            // 
            // gbRegistrarEmpleado
            // 
            this.gbRegistrarEmpleado.Controls.Add(this.btnActualizarCategoria);
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxActualizarDescripcionCategoria);
            this.gbRegistrarEmpleado.Controls.Add(this.label2);
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxActualizarNombreCategoria);
            this.gbRegistrarEmpleado.Controls.Add(this.label1);
            this.gbRegistrarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistrarEmpleado.Location = new System.Drawing.Point(12, 200);
            this.gbRegistrarEmpleado.Name = "gbRegistrarEmpleado";
            this.gbRegistrarEmpleado.Size = new System.Drawing.Size(776, 178);
            this.gbRegistrarEmpleado.TabIndex = 24;
            this.gbRegistrarEmpleado.TabStop = false;
            this.gbRegistrarEmpleado.Text = "Actualizar de Categoria";
            // 
            // btnActualizarCategoria
            // 
            this.btnActualizarCategoria.Location = new System.Drawing.Point(36, 117);
            this.btnActualizarCategoria.Name = "btnActualizarCategoria";
            this.btnActualizarCategoria.Size = new System.Drawing.Size(84, 32);
            this.btnActualizarCategoria.TabIndex = 18;
            this.btnActualizarCategoria.Text = "Actualizar";
            this.btnActualizarCategoria.UseVisualStyleBackColor = true;
            this.btnActualizarCategoria.Click += new System.EventHandler(this.btnActualizarCategoria_Click);
            // 
            // txtBoxActualizarDescripcionCategoria
            // 
            this.txtBoxActualizarDescripcionCategoria.Location = new System.Drawing.Point(133, 75);
            this.txtBoxActualizarDescripcionCategoria.Name = "txtBoxActualizarDescripcionCategoria";
            this.txtBoxActualizarDescripcionCategoria.Size = new System.Drawing.Size(265, 22);
            this.txtBoxActualizarDescripcionCategoria.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion:";
            // 
            // txtBoxActualizarNombreCategoria
            // 
            this.txtBoxActualizarNombreCategoria.Location = new System.Drawing.Point(113, 37);
            this.txtBoxActualizarNombreCategoria.Name = "txtBoxActualizarNombreCategoria";
            this.txtBoxActualizarNombreCategoria.Size = new System.Drawing.Size(231, 22);
            this.txtBoxActualizarNombreCategoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.Location = new System.Drawing.Point(644, 396);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(84, 32);
            this.btnAgregarCategoria.TabIndex = 25;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // FrmConsultarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.gbRegistrarEmpleado);
            this.Controls.Add(this.gbGestionCliente);
            this.Name = "FrmConsultarCategoria";
            this.Text = "FrmConsultarCategoria";
            this.Load += new System.EventHandler(this.FrmConsultarCategoria_Load);
            this.gbGestionCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.gbRegistrarEmpleado.ResumeLayout(false);
            this.gbRegistrarEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGestionCliente;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.GroupBox gbRegistrarEmpleado;
        private System.Windows.Forms.Button btnActualizarCategoria;
        private System.Windows.Forms.TextBox txtBoxActualizarDescripcionCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxActualizarNombreCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarCategoria;
    }
}