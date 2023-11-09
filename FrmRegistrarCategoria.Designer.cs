namespace WF_MiniMarket
{
    partial class FrmRegistrarCategoria
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
            this.btnGuardarCategoria = new System.Windows.Forms.Button();
            this.txtBoxRegistrarDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxRegistrarNombreCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbRegistrarEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistrarEmpleado
            // 
            this.gbRegistrarEmpleado.Controls.Add(this.btnGuardarCategoria);
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxRegistrarDescripcionCategoria);
            this.gbRegistrarEmpleado.Controls.Add(this.label2);
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxRegistrarNombreCategoria);
            this.gbRegistrarEmpleado.Controls.Add(this.label1);
            this.gbRegistrarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistrarEmpleado.Location = new System.Drawing.Point(12, 12);
            this.gbRegistrarEmpleado.Name = "gbRegistrarEmpleado";
            this.gbRegistrarEmpleado.Size = new System.Drawing.Size(776, 426);
            this.gbRegistrarEmpleado.TabIndex = 5;
            this.gbRegistrarEmpleado.TabStop = false;
            this.gbRegistrarEmpleado.Text = "Registrar de Categoria";
            // 
            // btnGuardarCategoria
            // 
            this.btnGuardarCategoria.Location = new System.Drawing.Point(36, 269);
            this.btnGuardarCategoria.Name = "btnGuardarCategoria";
            this.btnGuardarCategoria.Size = new System.Drawing.Size(84, 32);
            this.btnGuardarCategoria.TabIndex = 21;
            this.btnGuardarCategoria.Text = "Guardar";
            this.btnGuardarCategoria.UseVisualStyleBackColor = true;
            this.btnGuardarCategoria.Click += new System.EventHandler(this.btnGuardarCategoria_Click);
            // 
            // txtBoxRegistrarDescripcionCategoria
            // 
            this.txtBoxRegistrarDescripcionCategoria.Location = new System.Drawing.Point(133, 145);
            this.txtBoxRegistrarDescripcionCategoria.Name = "txtBoxRegistrarDescripcionCategoria";
            this.txtBoxRegistrarDescripcionCategoria.Size = new System.Drawing.Size(265, 22);
            this.txtBoxRegistrarDescripcionCategoria.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion:";
            // 
            // txtBoxRegistrarNombreCategoria
            // 
            this.txtBoxRegistrarNombreCategoria.Location = new System.Drawing.Point(113, 69);
            this.txtBoxRegistrarNombreCategoria.Name = "txtBoxRegistrarNombreCategoria";
            this.txtBoxRegistrarNombreCategoria.Size = new System.Drawing.Size(231, 22);
            this.txtBoxRegistrarNombreCategoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // FrmRegistrarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbRegistrarEmpleado);
            this.Name = "FrmRegistrarCategoria";
            this.Text = "FrmRegistrarCategoria";
            this.gbRegistrarEmpleado.ResumeLayout(false);
            this.gbRegistrarEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistrarEmpleado;
        private System.Windows.Forms.TextBox txtBoxRegistrarDescripcionCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxRegistrarNombreCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarCategoria;
    }
}