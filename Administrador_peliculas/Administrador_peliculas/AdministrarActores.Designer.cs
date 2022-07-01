namespace Administrador_peliculas
{
    partial class AdministradorActores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnModificarActuar = new System.Windows.Forms.Button();
            this.btnNuevoActor = new System.Windows.Forms.Button();
            this.MostrarActores = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbPalabrasClaves = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbSexoActor = new System.Windows.Forms.Label();
            this.cmbSexoActor = new System.Windows.Forms.ComboBox();
            this.btnRedireccionPelicular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnModificarActuar);
            this.groupBox1.Controls.Add(this.btnNuevoActor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 260);
            this.groupBox1.TabIndex = 6;
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
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btnModificarActuar
            // 
            this.btnModificarActuar.Location = new System.Drawing.Point(109, 18);
            this.btnModificarActuar.Name = "btnModificarActuar";
            this.btnModificarActuar.Size = new System.Drawing.Size(96, 23);
            this.btnModificarActuar.TabIndex = 11;
            this.btnModificarActuar.Text = "Modificar actor";
            this.btnModificarActuar.UseVisualStyleBackColor = true;
            this.btnModificarActuar.Click += new System.EventHandler(this.btnModificarActuar_Click);
            // 
            // btnNuevoActor
            // 
            this.btnNuevoActor.Location = new System.Drawing.Point(18, 18);
            this.btnNuevoActor.Name = "btnNuevoActor";
            this.btnNuevoActor.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoActor.TabIndex = 10;
            this.btnNuevoActor.Text = "Nuevo actor";
            this.btnNuevoActor.UseVisualStyleBackColor = true;
            this.btnNuevoActor.Click += new System.EventHandler(this.btnNuevoActor_Click);
            // 
            // MostrarActores
            // 
            this.MostrarActores.Location = new System.Drawing.Point(12, 278);
            this.MostrarActores.Name = "MostrarActores";
            this.MostrarActores.Size = new System.Drawing.Size(156, 25);
            this.MostrarActores.TabIndex = 14;
            this.MostrarActores.Text = "Mostrar actores";
            this.MostrarActores.UseVisualStyleBackColor = true;
            this.MostrarActores.Click += new System.EventHandler(this.MostrarActores_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.lbPalabrasClaves);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.lbSexoActor);
            this.groupBox2.Controls.Add(this.cmbSexoActor);
            this.groupBox2.Location = new System.Drawing.Point(512, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 251);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Búsqueda:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(20, 137);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(180, 37);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbSexoActor
            // 
            this.lbSexoActor.AutoSize = true;
            this.lbSexoActor.Location = new System.Drawing.Point(17, 37);
            this.lbSexoActor.Name = "lbSexoActor";
            this.lbSexoActor.Size = new System.Drawing.Size(34, 13);
            this.lbSexoActor.TabIndex = 15;
            this.lbSexoActor.Text = "Sexo:";
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
            this.cmbSexoActor.SelectedIndexChanged += new System.EventHandler(this.cmbSexoActor_SelectedIndexChanged);
            // 
            // btnRedireccionPelicular
            // 
            this.btnRedireccionPelicular.Location = new System.Drawing.Point(512, 278);
            this.btnRedireccionPelicular.Name = "btnRedireccionPelicular";
            this.btnRedireccionPelicular.Size = new System.Drawing.Size(211, 25);
            this.btnRedireccionPelicular.TabIndex = 20;
            this.btnRedireccionPelicular.Text = "Ir a administrador de peliculas";
            this.btnRedireccionPelicular.UseVisualStyleBackColor = true;
            this.btnRedireccionPelicular.Click += new System.EventHandler(this.btnRedireccionPelicular_Click);
            // 
            // AdministradorActores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 315);
            this.Controls.Add(this.btnRedireccionPelicular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MostrarActores);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdministradorActores";
            this.Text = "Administrador de actores";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnModificarActuar;
        private System.Windows.Forms.Button btnNuevoActor;
        private System.Windows.Forms.Button MostrarActores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbSexoActor;
        private System.Windows.Forms.ComboBox cmbSexoActor;
        private System.Windows.Forms.Label lbPalabrasClaves;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRedireccionPelicular;
    }
}

