namespace PacientesCesharp.vistas
{
    partial class AltaUsuarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.formulario = new System.Windows.Forms.GroupBox();
            this.botonRegistro = new System.Windows.Forms.Button();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.campoUsuario = new System.Windows.Forms.TextBox();
            this.campoPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.formulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 31);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PacientesCesharp.Properties.Resources.salud;
            this.pictureBox1.Location = new System.Drawing.Point(508, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 77);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // formulario
            // 
            this.formulario.Controls.Add(this.label2);
            this.formulario.Controls.Add(this.label1);
            this.formulario.Controls.Add(this.label4);
            this.formulario.Controls.Add(this.botonRegistro);
            this.formulario.Controls.Add(this.campoNombre);
            this.formulario.Controls.Add(this.campoUsuario);
            this.formulario.Controls.Add(this.campoPass);
            this.formulario.Location = new System.Drawing.Point(80, 89);
            this.formulario.Margin = new System.Windows.Forms.Padding(2);
            this.formulario.Name = "formulario";
            this.formulario.Padding = new System.Windows.Forms.Padding(2);
            this.formulario.Size = new System.Drawing.Size(364, 244);
            this.formulario.TabIndex = 7;
            this.formulario.TabStop = false;
            this.formulario.Text = "Registro Usuarios";
            // 
            // botonRegistro
            // 
            this.botonRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.botonRegistro.FlatAppearance.BorderSize = 2;
            this.botonRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.botonRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.botonRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistro.Location = new System.Drawing.Point(104, 203);
            this.botonRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.botonRegistro.Name = "botonRegistro";
            this.botonRegistro.Size = new System.Drawing.Size(67, 25);
            this.botonRegistro.TabIndex = 4;
            this.botonRegistro.Text = "Registrar";
            this.botonRegistro.UseVisualStyleBackColor = true;
            // 
            // campoNombre
            // 
            this.campoNombre.Location = new System.Drawing.Point(163, 47);
            this.campoNombre.Margin = new System.Windows.Forms.Padding(2);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(112, 20);
            this.campoNombre.TabIndex = 1;
            this.campoNombre.Tag = "NOMBRE";
            // 
            // campoUsuario
            // 
            this.campoUsuario.Location = new System.Drawing.Point(163, 106);
            this.campoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.campoUsuario.Name = "campoUsuario";
            this.campoUsuario.Size = new System.Drawing.Size(112, 20);
            this.campoUsuario.TabIndex = 2;
            this.campoUsuario.Tag = "USUARIOS";
            // 
            // campoPass
            // 
            this.campoPass.Location = new System.Drawing.Point(163, 160);
            this.campoPass.Margin = new System.Windows.Forms.Padding(2);
            this.campoPass.Name = "campoPass";
            this.campoPass.Size = new System.Drawing.Size(112, 20);
            this.campoPass.TabIndex = 3;
            this.campoPass.Tag = "CONTRASEÑA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre completo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AltaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 361);
            this.Controls.Add(this.formulario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AltaUsuarios";
            this.Text = "AltaUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.formulario.ResumeLayout(false);
            this.formulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox formulario;
        private System.Windows.Forms.Button botonRegistro;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.TextBox campoUsuario;
        private System.Windows.Forms.TextBox campoPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}