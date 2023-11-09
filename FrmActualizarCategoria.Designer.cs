namespace WF_MiniMarket
{
    partial class FrmActualizarCategoria
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
            this.btnActualizarCategoria = new System.Windows.Forms.Button();
            this.txtBoxActualizarDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxActualizarNombreCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbRegistrarEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistrarEmpleado
            // 
            this.gbRegistrarEmpleado.Controls.Add(this.btnActualizarCategoria);
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxActualizarDescripcionCategoria);
            this.gbRegistrarEmpleado.Controls.Add(this.label2);
            this.gbRegistrarEmpleado.Controls.Add(this.txtBoxActualizarNombreCategoria);
            this.gbRegistrarEmpleado.Controls.Add(this.label1);
            this.gbRegistrarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistrarEmpleado.Location = new System.Drawing.Point(12, 12);
            this.gbRegistrarEmpleado.Name = "gbRegistrarEmpleado";
            this.gbRegistrarEmpleado.Size = new System.Drawing.Size(776, 426);
            this.gbRegistrarEmpleado.TabIndex = 6;
            this.gbRegistrarEmpleado.TabStop = false;
            this.gbRegistrarEmpleado.Text = "Actualizar de Categoria";
            // 
            // btnActualizarCategoria
            // 
            this.btnActualizarCategoria.Location = new System.Drawing.Point(36, 235);
            this.btnActualizarCategoria.Name = "btnActualizarCategoria";
            this.btnActualizarCategoria.Size = new System.Drawing.Size(84, 32);
            this.btnActualizarCategoria.TabIndex = 18;
            this.btnActualizarCategoria.Text = "Actualizar";
            this.btnActualizarCategoria.UseVisualStyleBackColor = true;
            // 
            // txtBoxActualizarDescripcionCategoria
            // 
            this.txtBoxActualizarDescripcionCategoria.Location = new System.Drawing.Point(133, 141);
            this.txtBoxActualizarDescripcionCategoria.Name = "txtBoxActualizarDescripcionCategoria";
            this.txtBoxActualizarDescripcionCategoria.Size = new System.Drawing.Size(265, 22);
            this.txtBoxActualizarDescripcionCategoria.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion:";
            // 
            // txtBoxActualizarNombreCategoria
            // 
            this.txtBoxActualizarNombreCategoria.Location = new System.Drawing.Point(113, 66);
            this.txtBoxActualizarNombreCategoria.Name = "txtBoxActualizarNombreCategoria";
            this.txtBoxActualizarNombreCategoria.Size = new System.Drawing.Size(231, 22);
            this.txtBoxActualizarNombreCategoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // FrmActualizarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbRegistrarEmpleado);
            this.Name = "FrmActualizarCategoria";
            this.Text = "FrmActualizarCategoria";
            this.gbRegistrarEmpleado.ResumeLayout(false);
            this.gbRegistrarEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistrarEmpleado;
        private System.Windows.Forms.Button btnActualizarCategoria;
        private System.Windows.Forms.TextBox txtBoxActualizarDescripcionCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxActualizarNombreCategoria;
        private System.Windows.Forms.Label label1;
    }
}