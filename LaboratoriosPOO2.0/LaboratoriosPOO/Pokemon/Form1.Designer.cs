namespace Pokemon
{
    partial class frmPokemons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPokemons));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombrePokemon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEspeciePokemon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHabilidadPokemon = new System.Windows.Forms.TextBox();
            this.txtPesoPokemon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgbPokemons = new System.Windows.Forms.DataGridView();
            this.txtAlturaPokemon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboColorPokemon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHabitadPokemon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.imgPokemon = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.numFilas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgbPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtNombrePokemon
            // 
            this.txtNombrePokemon.Location = new System.Drawing.Point(87, 96);
            this.txtNombrePokemon.Name = "txtNombrePokemon";
            this.txtNombrePokemon.Size = new System.Drawing.Size(121, 20);
            this.txtNombrePokemon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Especie:";
            // 
            // txtEspeciePokemon
            // 
            this.txtEspeciePokemon.Location = new System.Drawing.Point(87, 142);
            this.txtEspeciePokemon.Name = "txtEspeciePokemon";
            this.txtEspeciePokemon.Size = new System.Drawing.Size(121, 20);
            this.txtEspeciePokemon.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Habilidad:";
            // 
            // txtHabilidadPokemon
            // 
            this.txtHabilidadPokemon.Location = new System.Drawing.Point(87, 185);
            this.txtHabilidadPokemon.Name = "txtHabilidadPokemon";
            this.txtHabilidadPokemon.Size = new System.Drawing.Size(121, 20);
            this.txtHabilidadPokemon.TabIndex = 5;
            // 
            // txtPesoPokemon
            // 
            this.txtPesoPokemon.Location = new System.Drawing.Point(87, 231);
            this.txtPesoPokemon.Name = "txtPesoPokemon";
            this.txtPesoPokemon.Size = new System.Drawing.Size(50, 20);
            this.txtPesoPokemon.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Peso(Kg):";
            // 
            // dgbPokemons
            // 
            this.dgbPokemons.AllowUserToAddRows = false;
            this.dgbPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbPokemons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numFilas,
            this.nombres,
            this.especie,
            this.habilidad,
            this.peso,
            this.altura,
            this.color,
            this.habitad});
            this.dgbPokemons.Location = new System.Drawing.Point(466, 96);
            this.dgbPokemons.Name = "dgbPokemons";
            this.dgbPokemons.ReadOnly = true;
            this.dgbPokemons.Size = new System.Drawing.Size(707, 291);
            this.dgbPokemons.TabIndex = 8;
            // 
            // txtAlturaPokemon
            // 
            this.txtAlturaPokemon.Location = new System.Drawing.Point(87, 275);
            this.txtAlturaPokemon.Name = "txtAlturaPokemon";
            this.txtAlturaPokemon.Size = new System.Drawing.Size(50, 20);
            this.txtAlturaPokemon.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Altura(m):";
            // 
            // cboColorPokemon
            // 
            this.cboColorPokemon.FormattingEnabled = true;
            this.cboColorPokemon.Location = new System.Drawing.Point(87, 319);
            this.cboColorPokemon.Name = "cboColorPokemon";
            this.cboColorPokemon.Size = new System.Drawing.Size(121, 21);
            this.cboColorPokemon.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Color:";
            // 
            // txtHabitadPokemon
            // 
            this.txtHabitadPokemon.Location = new System.Drawing.Point(87, 367);
            this.txtHabitadPokemon.Name = "txtHabitadPokemon";
            this.txtHabitadPokemon.Size = new System.Drawing.Size(121, 20);
            this.txtHabitadPokemon.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Habitad:";
            // 
            // imgPokemon
            // 
            this.imgPokemon.Location = new System.Drawing.Point(227, 96);
            this.imgPokemon.Name = "imgPokemon";
            this.imgPokemon.Size = new System.Drawing.Size(233, 291);
            this.imgPokemon.TabIndex = 15;
            this.imgPokemon.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(87, 416);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Crear/Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(227, 416);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(496, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 38);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mundo Pokémon";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(789, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(324, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // numFilas
            // 
            this.numFilas.HeaderText = "N°";
            this.numFilas.Name = "numFilas";
            this.numFilas.ReadOnly = true;
            this.numFilas.Width = 30;
            // 
            // nombres
            // 
            this.nombres.HeaderText = "NOMBRES";
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            // 
            // especie
            // 
            this.especie.HeaderText = "ESPECIE";
            this.especie.Name = "especie";
            this.especie.ReadOnly = true;
            // 
            // habilidad
            // 
            this.habilidad.HeaderText = "HABILIDAD";
            this.habilidad.Name = "habilidad";
            this.habilidad.ReadOnly = true;
            // 
            // peso
            // 
            this.peso.HeaderText = "PESO";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            this.peso.Width = 70;
            // 
            // altura
            // 
            this.altura.HeaderText = "ALTURA";
            this.altura.Name = "altura";
            this.altura.ReadOnly = true;
            this.altura.Width = 70;
            // 
            // color
            // 
            this.color.HeaderText = "COLOR";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            // 
            // habitad
            // 
            this.habitad.HeaderText = "HABITAD";
            this.habitad.Name = "habitad";
            this.habitad.ReadOnly = true;
            // 
            // frmPokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1208, 493);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.imgPokemon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHabitadPokemon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboColorPokemon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAlturaPokemon);
            this.Controls.Add(this.dgbPokemons);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPesoPokemon);
            this.Controls.Add(this.txtHabilidadPokemon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEspeciePokemon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombrePokemon);
            this.Controls.Add(this.label1);
            this.Name = "frmPokemons";
            this.Text = "Pokemons | Creando";
            this.Load += new System.EventHandler(this.frmPokemons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombrePokemon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEspeciePokemon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHabilidadPokemon;
        private System.Windows.Forms.TextBox txtPesoPokemon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgbPokemons;
        private System.Windows.Forms.TextBox txtAlturaPokemon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboColorPokemon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHabitadPokemon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox imgPokemon;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFilas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn habilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitad;
    }
}

