namespace Administrador_peliculas
{
    partial class AdministrarPeliculas
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
            this.btnRedireccionActores = new System.Windows.Forms.Button();
            this.gpbBusquedas = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbPalabrasClaves = new System.Windows.Forms.Label();
            this.txtPalabraClave = new System.Windows.Forms.TextBox();
            this.lbGeneroPelicula = new System.Windows.Forms.Label();
            this.cmbSexoActor = new System.Windows.Forms.ComboBox();
            this.MostrarPeliculas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnModificarPelicula = new System.Windows.Forms.Button();
            this.btnNuevaPelicula = new System.Windows.Forms.Button();
            this.gpbBusquedas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRedireccionActores
            // 
            this.btnRedireccionActores.Location = new System.Drawing.Point(512, 278);
            this.btnRedireccionActores.Name = "btnRedireccionActores";
            this.btnRedireccionActores.Size = new System.Drawing.Size(211, 25);
            this.btnRedireccionActores.TabIndex = 24;
            this.btnRedireccionActores.Text = "Ir a administrador de actores";
            this.btnRedireccionActores.UseVisualStyleBackColor = true;
            this.btnRedireccionActores.Click += new System.EventHandler(this.btnRedireccionActores_Click);
            // 
            // gpbBusquedas
            // 
            this.gpbBusquedas.Controls.Add(this.btnBuscar);
            this.gpbBusquedas.Controls.Add(this.lbPalabrasClaves);
            this.gpbBusquedas.Controls.Add(this.txtPalabraClave);
            this.gpbBusquedas.Controls.Add(this.lbGeneroPelicula);
            this.gpbBusquedas.Controls.Add(this.cmbSexoActor);
            this.gpbBusquedas.Location = new System.Drawing.Point(512, 21);
            this.gpbBusquedas.Name = "gpbBusquedas";
            this.gpbBusquedas.Size = new System.Drawing.Size(217, 251);
            this.gpbBusquedas.TabIndex = 23;
            this.gpbBusquedas.TabStop = false;
            this.gpbBusquedas.Text = "Búsqueda:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(20, 137);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(180, 37);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lbPalabrasClaves
            // 
            this.lbPalabrasClaves.AutoSize = true;
            this.lbPalabrasClaves.Location = new System.Drawing.Point(9, 91);
            this.lbPalabrasClaves.Name = "lbPalabrasClaves";
            this.lbPalabrasClaves.Size = new System.Drawing.Size(75, 13);
            this.lbPalabrasClaves.TabIndex = 18;
            this.lbPalabrasClaves.Text = "Palabra clave:";
            // 
            // txtPalabraClave
            // 
            this.txtPalabraClave.Location = new System.Drawing.Point(90, 84);
            this.txtPalabraClave.Name = "txtPalabraClave";
            this.txtPalabraClave.Size = new System.Drawing.Size(121, 20);
            this.txtPalabraClave.TabIndex = 17;
            // 
            // lbGeneroPelicula
            // 
            this.lbGeneroPelicula.AutoSize = true;
            this.lbGeneroPelicula.Location = new System.Drawing.Point(17, 37);
            this.lbGeneroPelicula.Name = "lbGeneroPelicula";
            this.lbGeneroPelicula.Size = new System.Drawing.Size(45, 13);
            this.lbGeneroPelicula.TabIndex = 15;
            this.lbGeneroPelicula.Text = "Genero:";
            // 
            // cmbSexoActor
            // 
            this.cmbSexoActor.FormattingEnabled = true;
            this.cmbSexoActor.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexoActor.Location = new System.Drawing.Point(90, 34);
            this.cmbSexoActor.Name = "cmbSexoActor";
            this.cmbSexoActor.Size = new System.Drawing.Size(121, 21);
            this.cmbSexoActor.TabIndex = 16;
            // 
            // MostrarPeliculas
            // 
            this.MostrarPeliculas.Location = new System.Drawing.Point(12, 278);
            this.MostrarPeliculas.Name = "MostrarPeliculas";
            this.MostrarPeliculas.Size = new System.Drawing.Size(156, 25);
            this.MostrarPeliculas.TabIndex = 22;
            this.MostrarPeliculas.Text = "Mostrar Peliculas";
            this.MostrarPeliculas.UseVisualStyleBackColor = true;
            this.MostrarPeliculas.Click += new System.EventHandler(this.MostrarPeliculas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnModificarPelicula);
            this.groupBox1.Controls.Add(this.btnNuevaPelicula);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 260);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar/modificar:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(452, 177);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnModificarPelicula
            // 
            this.btnModificarPelicula.Location = new System.Drawing.Point(135, 18);
            this.btnModificarPelicula.Name = "btnModificarPelicula";
            this.btnModificarPelicula.Size = new System.Drawing.Size(119, 23);
            this.btnModificarPelicula.TabIndex = 11;
            this.btnModificarPelicula.Text = "Modificar Pelicula";
            this.btnModificarPelicula.UseVisualStyleBackColor = true;
            this.btnModificarPelicula.Click += new System.EventHandler(this.btnModificarPelicula_Click);
            // 
            // btnNuevaPelicula
            // 
            this.btnNuevaPelicula.Location = new System.Drawing.Point(18, 18);
            this.btnNuevaPelicula.Name = "btnNuevaPelicula";
            this.btnNuevaPelicula.Size = new System.Drawing.Size(111, 23);
            this.btnNuevaPelicula.TabIndex = 10;
            this.btnNuevaPelicula.Text = "Nueva Pelicula";
            this.btnNuevaPelicula.UseVisualStyleBackColor = true;
            this.btnNuevaPelicula.Click += new System.EventHandler(this.btnNuevaPelicula_Click);
            // 
            // AdministrarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 322);
            this.Controls.Add(this.btnRedireccionActores);
            this.Controls.Add(this.gpbBusquedas);
            this.Controls.Add(this.MostrarPeliculas);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdministrarPeliculas";
            this.Text = "AdministrarPeliculascs";
            this.gpbBusquedas.ResumeLayout(false);
            this.gpbBusquedas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRedireccionActores;
        private System.Windows.Forms.GroupBox gpbBusquedas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbPalabrasClaves;
        private System.Windows.Forms.TextBox txtPalabraClave;
        private System.Windows.Forms.Label lbGeneroPelicula;
        private System.Windows.Forms.ComboBox cmbSexoActor;
        private System.Windows.Forms.Button MostrarPeliculas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnModificarPelicula;
        private System.Windows.Forms.Button btnNuevaPelicula;
    }
}