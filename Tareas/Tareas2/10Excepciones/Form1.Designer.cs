namespace _10Excepciones
{
    partial class frmEmpleado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEdadEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEdadEmpleado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombreEmpleado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumeroEmpleado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Empleado";
            // 
            // txtEdadEmpleado
            // 
            this.txtEdadEmpleado.Location = new System.Drawing.Point(75, 95);
            this.txtEdadEmpleado.Name = "txtEdadEmpleado";
            this.txtEdadEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtEdadEmpleado.TabIndex = 5;
            this.txtEdadEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdadEmpleado_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad:";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(75, 62);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(207, 20);
            this.txtNombreEmpleado.TabIndex = 3;
            this.txtNombreEmpleado.TextChanged += new System.EventHandler(this.txtNombreEmpleado_TextChanged);
            this.txtNombreEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEmpleado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtNumeroEmpleado
            // 
            this.txtNumeroEmpleado.Location = new System.Drawing.Point(75, 30);
            this.txtNumeroEmpleado.MaxLength = 5;
            this.txtNumeroEmpleado.MinimumSize = new System.Drawing.Size(5, 4);
            this.txtNumeroEmpleado.Name = "txtNumeroEmpleado";
            this.txtNumeroEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroEmpleado.TabIndex = 1;
            this.txtNumeroEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroEmpleado_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(36, 188);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 1;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(219, 188);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmEmpleado
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(321, 229);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.groupBox1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmEmpleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEdadEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnSalir;
    }
}

