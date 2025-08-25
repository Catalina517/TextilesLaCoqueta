namespace CapaPresentacion
{
    partial class frmGestionNomina
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
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label14.Location = new System.Drawing.Point(11, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(709, 16);
            this.label14.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Gestión de Nómina";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(705, 282);
            this.dataGridView1.TabIndex = 33;
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(223, 86);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(151, 30);
            this.txtCod.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Código del Empleado:";
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEmpleado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(450, 77);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(171, 59);
            this.btnBuscarEmpleado.TabIndex = 36;
            this.btnBuscarEmpleado.Text = "BUSCAR EMPLEADO";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = false;
            // 
            // frmGestionNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Name = "frmGestionNomina";
            this.Text = "Gestión de Nomina";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarEmpleado;
    }
}