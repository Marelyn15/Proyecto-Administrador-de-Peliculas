namespace Administrador_peliculas
{
    partial class Administrador_de_peliculas1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbPalabrasClaves = new System.Windows.Forms.Label();
            this.txtPalabraClave = new System.Windows.Forms.TextBox();
            this.lbGeneroPelicula = new System.Windows.Forms.Label();
            this.cmbSexoActor = new System.Windows.Forms.ComboBox();
            this.MostrarActores = new System.Windows.Forms.Button();
            this.grpAgregarModificar = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnModificarActuar = new System.Windows.Forms.Button();
            this.btnNuevaPelicula = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.grpAgregarModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbPalabrasClaves);
            this.groupBox2.Controls.Add(this.txtPalabraClave);
            this.groupBox2.Controls.Add(this.lbGeneroPelicula);
            this.groupBox2.Controls.Add(this.cmbSexoActor);
            this.groupBox2.Location = new System.Drawing.Point(536, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 251);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Búsqueda:";
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
            this.cmbSexoActor.Location = new System.Drawing.Point(90, 34);
            this.cmbSexoActor.Name = "cmbSexoActor";
            this.cmbSexoActor.Size = new System.Drawing.Size(121, 21);
            this.cmbSexoActor.TabIndex = 16;
            // 
            // MostrarActores
            // 
            this.MostrarActores.Location = new System.Drawing.Point(12, 290);
            this.MostrarActores.Name = "MostrarActores";
            this.MostrarActores.Size = new System.Drawing.Size(156, 25);
            this.MostrarActores.TabIndex = 17;
            this.MostrarActores.Text = "Mostrar Peliculas";
            this.MostrarActores.UseVisualStyleBackColor = true;
            // 
            // grpAgregarModificar
            // 
            this.grpAgregarModificar.Controls.Add(this.dataGridView1);
            this.grpAgregarModificar.Controls.Add(this.btnModificarActuar);
            this.grpAgregarModificar.Controls.Add(this.btnNuevaPelicula);
            this.grpAgregarModificar.Location = new System.Drawing.Point(12, 24);
            this.grpAgregarModificar.Name = "grpAgregarModificar";
            this.grpAgregarModificar.Size = new System.Drawing.Size(518, 260);
            this.grpAgregarModificar.TabIndex = 16;
            this.grpAgregarModificar.TabStop = false;
            this.grpAgregarModificar.Text = "Agregar/modificar:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(452, 177);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnModificarActuar
            // 
            this.btnModificarActuar.Location = new System.Drawing.Point(139, 19);
            this.btnModificarActuar.Name = "btnModificarActuar";
            this.btnModificarActuar.Size = new System.Drawing.Size(109, 23);
            this.btnModificarActuar.TabIndex = 11;
            this.btnModificarActuar.Text = "Modificar pelicula";
            this.btnModificarActuar.UseVisualStyleBackColor = true;
            // 
            // btnNuevaPelicula
            // 
            this.btnNuevaPelicula.Location = new System.Drawing.Point(18, 18);
            this.btnNuevaPelicula.Name = "btnNuevaPelicula";
            this.btnNuevaPelicula.Size = new System.Drawing.Size(104, 23);
            this.btnNuevaPelicula.TabIndex = 10;
            this.btnNuevaPelicula.Text = "Nueva pelicula";
            this.btnNuevaPelicula.UseVisualStyleBackColor = true;
            // 
            // Administrador_de_peliculas1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MostrarActores);
            this.Controls.Add(this.grpAgregarModificar);
            this.Name = "Administrador_de_peliculas1";
            this.Text = "Administrador_de_peliculas1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpAgregarModificar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbPalabrasClaves;
        private System.Windows.Forms.TextBox txtPalabraClave;
        private System.Windows.Forms.Label lbGeneroPelicula;
        private System.Windows.Forms.ComboBox cmbSexoActor;
        private System.Windows.Forms.Button MostrarActores;
        private System.Windows.Forms.GroupBox grpAgregarModificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnModificarActuar;
        private System.Windows.Forms.Button btnNuevaPelicula;
    }
}