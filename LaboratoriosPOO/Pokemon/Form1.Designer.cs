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
            this.label2 = new System.Windows.Forms.Label();
            this.txtEspeciePokemon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHabilidadPokemon = new System.Windows.Forms.TextBox();
            this.txtPesoPokemon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgbPokemons = new System.Windows.Forms.DataGridView();
            this.numFilas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitad = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cboNombre = new System.Windows.Forms.ComboBox();
            this.grpPokémon = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEdadEntrenador = new System.Windows.Forms.TextBox();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.imgEntrenador = new System.Windows.Forms.PictureBox();
            this.cboEntrenador = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgbPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpPokémon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEntrenador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Especie:";
            // 
            // txtEspeciePokemon
            // 
            this.txtEspeciePokemon.Location = new System.Drawing.Point(68, 70);
            this.txtEspeciePokemon.Name = "txtEspeciePokemon";
            this.txtEspeciePokemon.Size = new System.Drawing.Size(121, 20);
            this.txtEspeciePokemon.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Habilidad:";
            // 
            // txtHabilidadPokemon
            // 
            this.txtHabilidadPokemon.Location = new System.Drawing.Point(68, 109);
            this.txtHabilidadPokemon.Name = "txtHabilidadPokemon";
            this.txtHabilidadPokemon.Size = new System.Drawing.Size(121, 20);
            this.txtHabilidadPokemon.TabIndex = 5;
            // 
            // txtPesoPokemon
            // 
            this.txtPesoPokemon.Location = new System.Drawing.Point(68, 152);
            this.txtPesoPokemon.Name = "txtPesoPokemon";
            this.txtPesoPokemon.Size = new System.Drawing.Size(50, 20);
            this.txtPesoPokemon.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 155);
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
            this.dgbPokemons.Location = new System.Drawing.Point(49, 641);
            this.dgbPokemons.Name = "dgbPokemons";
            this.dgbPokemons.ReadOnly = true;
            this.dgbPokemons.Size = new System.Drawing.Size(707, 235);
            this.dgbPokemons.TabIndex = 8;
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
            // txtAlturaPokemon
            // 
            this.txtAlturaPokemon.Location = new System.Drawing.Point(68, 199);
            this.txtAlturaPokemon.Name = "txtAlturaPokemon";
            this.txtAlturaPokemon.Size = new System.Drawing.Size(50, 20);
            this.txtAlturaPokemon.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Altura(m):";
            // 
            // cboColorPokemon
            // 
            this.cboColorPokemon.FormattingEnabled = true;
            this.cboColorPokemon.Location = new System.Drawing.Point(68, 243);
            this.cboColorPokemon.Name = "cboColorPokemon";
            this.cboColorPokemon.Size = new System.Drawing.Size(121, 21);
            this.cboColorPokemon.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Color:";
            // 
            // txtHabitadPokemon
            // 
            this.txtHabitadPokemon.Location = new System.Drawing.Point(68, 299);
            this.txtHabitadPokemon.Name = "txtHabitadPokemon";
            this.txtHabitadPokemon.Size = new System.Drawing.Size(121, 20);
            this.txtHabitadPokemon.TabIndex = 13;
            this.txtHabitadPokemon.TextChanged += new System.EventHandler(this.txtHabitadPokemon_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Habitad:";
            // 
            // imgPokemon
            // 
            this.imgPokemon.Location = new System.Drawing.Point(204, 28);
            this.imgPokemon.Name = "imgPokemon";
            this.imgPokemon.Size = new System.Drawing.Size(233, 291);
            this.imgPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPokemon.TabIndex = 15;
            this.imgPokemon.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(50, 346);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Crear/Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(181, 346);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 23);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(564, 9);
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
            this.pictureBox1.Location = new System.Drawing.Point(835, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // cboNombre
            // 
            this.cboNombre.FormattingEnabled = true;
            this.cboNombre.Location = new System.Drawing.Point(68, 28);
            this.cboNombre.Name = "cboNombre";
            this.cboNombre.Size = new System.Drawing.Size(121, 21);
            this.cboNombre.TabIndex = 21;
            this.cboNombre.SelectedIndexChanged += new System.EventHandler(this.cboNombre_SelectedIndexChanged);
            // 
            // grpPokémon
            // 
            this.grpPokémon.Controls.Add(this.cboNombre);
            this.grpPokémon.Controls.Add(this.imgPokemon);
            this.grpPokémon.Controls.Add(this.label7);
            this.grpPokémon.Controls.Add(this.btnLimpiar);
            this.grpPokémon.Controls.Add(this.txtHabitadPokemon);
            this.grpPokémon.Controls.Add(this.btnAgregar);
            this.grpPokémon.Controls.Add(this.label6);
            this.grpPokémon.Controls.Add(this.cboColorPokemon);
            this.grpPokémon.Controls.Add(this.label5);
            this.grpPokémon.Controls.Add(this.txtAlturaPokemon);
            this.grpPokémon.Controls.Add(this.label4);
            this.grpPokémon.Controls.Add(this.txtPesoPokemon);
            this.grpPokémon.Controls.Add(this.txtHabilidadPokemon);
            this.grpPokémon.Controls.Add(this.label3);
            this.grpPokémon.Controls.Add(this.txtEspeciePokemon);
            this.grpPokémon.Controls.Add(this.label2);
            this.grpPokémon.Controls.Add(this.label1);
            this.grpPokémon.Location = new System.Drawing.Point(49, 254);
            this.grpPokémon.Name = "grpPokémon";
            this.grpPokémon.Size = new System.Drawing.Size(457, 381);
            this.grpPokémon.TabIndex = 22;
            this.grpPokémon.TabStop = false;
            this.grpPokémon.Text = "Pokémon:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(437, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboEntrenador);
            this.groupBox1.Controls.Add(this.imgEntrenador);
            this.groupBox1.Controls.Add(this.rbF);
            this.groupBox1.Controls.Add(this.rbM);
            this.groupBox1.Controls.Add(this.txtEdadEntrenador);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(49, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 180);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrenador:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Genero:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Edad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Nombre:";
            // 
            // txtEdadEntrenador
            // 
            this.txtEdadEntrenador.Location = new System.Drawing.Point(78, 118);
            this.txtEdadEntrenador.Name = "txtEdadEntrenador";
            this.txtEdadEntrenador.Size = new System.Drawing.Size(121, 20);
            this.txtEdadEntrenador.TabIndex = 7;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(78, 82);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(34, 17);
            this.rbM.TabIndex = 8;
            this.rbM.TabStop = true;
            this.rbM.Text = "M";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(137, 82);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(31, 17);
            this.rbF.TabIndex = 9;
            this.rbF.TabStop = true;
            this.rbF.Text = "F";
            this.rbF.UseVisualStyleBackColor = true;
            // 
            // imgEntrenador
            // 
            this.imgEntrenador.Location = new System.Drawing.Point(279, 28);
            this.imgEntrenador.Name = "imgEntrenador";
            this.imgEntrenador.Size = new System.Drawing.Size(127, 133);
            this.imgEntrenador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEntrenador.TabIndex = 10;
            this.imgEntrenador.TabStop = false;
            // 
            // cboEntrenador
            // 
            this.cboEntrenador.FormattingEnabled = true;
            this.cboEntrenador.Location = new System.Drawing.Point(78, 38);
            this.cboEntrenador.Name = "cboEntrenador";
            this.cboEntrenador.Size = new System.Drawing.Size(121, 21);
            this.cboEntrenador.TabIndex = 22;
            this.cboEntrenador.SelectedIndexChanged += new System.EventHandler(this.cboEntrenador_SelectedIndexChanged);
            this.cboEntrenador.Click += new System.EventHandler(this.cboEntrenador_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Forte", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(642, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 70);
            this.label12.TabIndex = 25;
            this.label12.Text = "VS.";
            // 
            // frmPokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1264, 888);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grpPokémon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgbPokemons);
            this.Name = "frmPokemons";
            this.Text = "Pokemons | Creando";
            this.Load += new System.EventHandler(this.frmPokemons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpPokémon.ResumeLayout(false);
            this.grpPokémon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEntrenador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn numFilas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn habilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitad;
        private System.Windows.Forms.ComboBox cboNombre;
        private System.Windows.Forms.GroupBox grpPokémon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboEntrenador;
        private System.Windows.Forms.PictureBox imgEntrenador;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.TextBox txtEdadEntrenador;
        private System.Windows.Forms.Label label12;
    }
}

