namespace Administrador_peliculas
{
    partial class ModificarActor
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
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(200, 278);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(64, 278);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 23);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtSexo);
            this.gbDatos.Controls.Add(this.txtFechaNacimiento);
            this.gbDatos.Controls.Add(this.lbPelicula);
            this.gbDatos.Controls.Add(this.txtPelicula);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.lbSexo);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.lbNombre);
            this.gbDatos.Location = new System.Drawing.Point(21, 11);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(371, 250);
            this.gbDatos.TabIndex = 12;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos:";
            // 
            // lbPelicula
            // 
            this.lbPelicula.AutoSize = true;
            this.lbPelicula.Location = new System.Drawing.Point(19, 181);
            this.lbPelicula.Name = "lbPelicula";
            this.lbPelicula.Size = new System.Drawing.Size(50, 13);
            this.lbPelicula.TabIndex = 17;
            this.lbPelicula.Text = "Pelicula: ";
            // 
            // txtPelicula
            // 
            this.txtPelicula.Location = new System.Drawing.Point(127, 178);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.Size = new System.Drawing.Size(207, 20);
            this.txtPelicula.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha Nacimiento: ";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(19, 78);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(37, 13);
            this.lbSexo.TabIndex = 11;
            this.lbSexo.Text = "Sexo: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 26);
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
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(127, 128);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(207, 20);
            this.txtFechaNacimiento.TabIndex = 20;
            this.txtFechaNacimiento.Text = "AAAA-MM-DD";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(127, 78);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(207, 20);
            this.txtSexo.TabIndex = 21;
            // 
            // ModificarActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 313);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbDatos);
            this.Name = "ModificarActor";
            this.Text = "ModificarActores";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lbPelicula;
        private System.Windows.Forms.TextBox txtPelicula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtSexo;
    }
}