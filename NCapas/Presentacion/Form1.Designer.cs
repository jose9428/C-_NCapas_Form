namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.dataGridAlumno = new System.Windows.Forms.DataGridView();
            this.BtnVerPagos = new System.Windows.Forms.Button();
            this.btnMantAlumnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Especialidad";
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(132, 22);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(139, 21);
            this.cbEspecialidad.TabIndex = 1;
            this.cbEspecialidad.SelectionChangeCommitted += new System.EventHandler(this.cbEspecialidad_SelectionChangeCommitted);
            // 
            // dataGridAlumno
            // 
            this.dataGridAlumno.AllowUserToAddRows = false;
            this.dataGridAlumno.AllowUserToDeleteRows = false;
            this.dataGridAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlumno.Location = new System.Drawing.Point(26, 72);
            this.dataGridAlumno.Name = "dataGridAlumno";
            this.dataGridAlumno.ReadOnly = true;
            this.dataGridAlumno.Size = new System.Drawing.Size(565, 231);
            this.dataGridAlumno.TabIndex = 2;
            // 
            // BtnVerPagos
            // 
            this.BtnVerPagos.Location = new System.Drawing.Point(516, 43);
            this.BtnVerPagos.Name = "BtnVerPagos";
            this.BtnVerPagos.Size = new System.Drawing.Size(75, 23);
            this.BtnVerPagos.TabIndex = 3;
            this.BtnVerPagos.Text = "Ver Pagos";
            this.BtnVerPagos.UseVisualStyleBackColor = true;
            this.BtnVerPagos.Click += new System.EventHandler(this.BtnVerPagos_Click);
            // 
            // btnMantAlumnos
            // 
            this.btnMantAlumnos.Location = new System.Drawing.Point(26, 317);
            this.btnMantAlumnos.Name = "btnMantAlumnos";
            this.btnMantAlumnos.Size = new System.Drawing.Size(167, 23);
            this.btnMantAlumnos.TabIndex = 4;
            this.btnMantAlumnos.Text = "Mantenimiento Alumnos";
            this.btnMantAlumnos.UseVisualStyleBackColor = true;
            this.btnMantAlumnos.Click += new System.EventHandler(this.btnMantAlumnos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 352);
            this.Controls.Add(this.btnMantAlumnos);
            this.Controls.Add(this.BtnVerPagos);
            this.Controls.Add(this.dataGridAlumno);
            this.Controls.Add(this.cbEspecialidad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.DataGridView dataGridAlumno;
        private System.Windows.Forms.Button BtnVerPagos;
        private System.Windows.Forms.Button btnMantAlumnos;
    }
}

