namespace Administrador_peliculas
{
    partial class AgregarActor
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lbPelicula = new System.Windows.Forms.Label();
            this.txtPeliculas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(191, 279);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(55, 279);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 23);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtFechaNacimiento);
            this.gbDatos.Controls.Add(this.txtSexo);
            this.gbDatos.Controls.Add(this.lbPelicula);
            this.gbDatos.Controls.Add(this.txtPeliculas);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.lbSexo);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.lbNombre);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(371, 250);
            this.gbDatos.TabIndex = 15;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos:";
            // 
            // lbPelicula
            // 
            this.lbPelicula.AutoSize = true;
            this.lbPelicula.Location = new System.Drawing.Point(19, 208);
            this.lbPelicula.Name = "lbPelicula";
            this.lbPelicula.Size = new System.Drawing.Size(50, 13);
            this.lbPelicula.TabIndex = 17;
            this.lbPelicula.Text = "Pelicula: ";
            // 
            // txtPeliculas
            // 
            this.txtPeliculas.Location = new System.Drawing.Point(139, 205);
            this.txtPeliculas.Name = "txtPeliculas";
            this.txtPeliculas.Size = new System.Drawing.Size(207, 20);
            this.txtPeliculas.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha de Nacimiento: ";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(19, 78);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(66, 13);
            this.lbSexo.TabIndex = 11;
            this.lbSexo.Text = "Sexo (F/M): ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(207, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(19, 26);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(50, 13);
            this.lbNombre.TabIndex = 9;
            this.lbNombre.Text = "Nombre: ";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(139, 75);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(207, 20);
            this.txtSexo.TabIndex = 18;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(139, 135);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(207, 20);
            this.txtFechaNacimiento.TabIndex = 19;
            this.txtFechaNacimiento.Text = "AAAA-MM-DD";
            // 
            // AgregarActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 315);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbDatos);
            this.Name = "AgregarActor";
            this.Text = "AgregarActor";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lbPelicula;
        private System.Windows.Forms.TextBox txtPeliculas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
    }
}