namespace _09HerenciaMultiple
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHorasTrabajo = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(68, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(162, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos :";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(68, 48);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(162, 20);
            this.txtApellidos.TabIndex = 3;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Horas Semanales:";
            // 
            // txtHorasTrabajo
            // 
            this.txtHorasTrabajo.Location = new System.Drawing.Point(342, 19);
            this.txtHorasTrabajo.MaxLength = 3;
            this.txtHorasTrabajo.MinimumSize = new System.Drawing.Size(3, 0);
            this.txtHorasTrabajo.Name = "txtHorasTrabajo";
            this.txtHorasTrabajo.Size = new System.Drawing.Size(61, 20);
            this.txtHorasTrabajo.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(68, 91);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Resgistrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(15, 120);
            this.txtR.Multiline = true;
            this.txtR.Name = "txtR";
            this.txtR.ReadOnly = true;
            this.txtR.Size = new System.Drawing.Size(388, 154);
            this.txtR.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(316, 48);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.MinimumSize = new System.Drawing.Size(8, 0);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(87, 20);
            this.txtDNI.TabIndex = 12;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(236, 91);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(415, 286);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtHorasTrabajo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Registro ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHorasTrabajo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnSalir;
    }
}

