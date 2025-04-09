using PacientesCesharp.bbdd;
using PacientesCesharp.utilidades;
using System.Reflection;
using System.Windows.Forms;

namespace PacientesCesharp.vistas
{
    partial class AltaPacientes
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.formulario = new System.Windows.Forms.GroupBox();
            this.botonRegitrar = new System.Windows.Forms.Button();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.campoApellidos = new System.Windows.Forms.TextBox();
            this.campoDireccion = new System.Windows.Forms.TextBox();
            this.comboCiudad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.formulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PacientesCesharp.Properties.Resources.salud;
            this.pictureBox1.Location = new System.Drawing.Point(508, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 77);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 31);
            this.panel1.TabIndex = 3;
            // 
            // formulario
            // 
            this.formulario.Controls.Add(this.botonRegitrar);
            this.formulario.Controls.Add(this.campoNombre);
            this.formulario.Controls.Add(this.campoApellidos);
            this.formulario.Controls.Add(this.campoDireccion);
            this.formulario.Controls.Add(this.comboCiudad);
            this.formulario.Controls.Add(this.label4);
            this.formulario.Controls.Add(this.label3);
            this.formulario.Controls.Add(this.label2);
            this.formulario.Controls.Add(this.label1);
            this.formulario.Location = new System.Drawing.Point(41, 97);
            this.formulario.Name = "formulario";
            this.formulario.Size = new System.Drawing.Size(442, 235);
            this.formulario.TabIndex = 4;
            this.formulario.TabStop = false;
            this.formulario.Text = "ALTA DE NUEVO PACIENTE";
            // 
            // botonRegitrar
            // 
            this.botonRegitrar.Location = new System.Drawing.Point(155, 198);
            this.botonRegitrar.Name = "botonRegitrar";
            this.botonRegitrar.Size = new System.Drawing.Size(83, 22);
            this.botonRegitrar.TabIndex = 5;
            this.botonRegitrar.Text = "Regitrar";
            this.botonRegitrar.UseVisualStyleBackColor = true;
            this.botonRegitrar.Click += new System.EventHandler(this.botonRegitrar_Click);
            // 
            // campoNombre
            // 
            this.campoNombre.Location = new System.Drawing.Point(155, 47);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(121, 20);
            this.campoNombre.TabIndex = 1;
            this.campoNombre.Tag = "Nombre";
            this.campoNombre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // campoApellidos
            // 
            this.campoApellidos.Location = new System.Drawing.Point(155, 88);
            this.campoApellidos.Name = "campoApellidos";
            this.campoApellidos.Size = new System.Drawing.Size(200, 20);
            this.campoApellidos.TabIndex = 2;
            this.campoApellidos.Tag = "Apellidos";
            this.campoApellidos.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // campoDireccion
            // 
            this.campoDireccion.Location = new System.Drawing.Point(155, 122);
            this.campoDireccion.Name = "campoDireccion";
            this.campoDireccion.Size = new System.Drawing.Size(200, 20);
            this.campoDireccion.TabIndex = 3;
            this.campoDireccion.Tag = "Direccion";
            this.campoDireccion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboCiudad
            // 
            this.comboCiudad.FormattingEnabled = true;
            this.comboCiudad.ItemHeight = 13;
            this.comboCiudad.Location = new System.Drawing.Point(155, 159);
            this.comboCiudad.Name = "comboCiudad";
            this.comboCiudad.Size = new System.Drawing.Size(121, 21);
            this.comboCiudad.TabIndex = 4;
            this.comboCiudad.Tag = "Ciudad";
            this.comboCiudad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AltaPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 361);
            this.Controls.Add(this.formulario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(610, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(610, 400);
            this.Name = "AltaPacientes";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.formulario.ResumeLayout(false);
            this.formulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox formulario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.TextBox campoApellidos;
        private System.Windows.Forms.TextBox campoDireccion;
        private System.Windows.Forms.ComboBox comboCiudad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonRegitrar;

        public void Registrar()

        {
            string nombre = Encriptado.Encriptar(campoNombre.Text);
            string apellidos = Encriptado.Encriptar(campoApellidos.Text);
            string direccion = Encriptado.Encriptar(campoDireccion.Text);
            string ciudad = Encriptado.Encriptar(comboCiudad.Text);

            if (Validaciones.ValidarFormulario(formulario))
            {
                modelo.Paciente paciente = new modelo.Paciente(nombre, apellidos, direccion, ciudad);
                if (!conexion.RegistrarPaciente(paciente))
                {
                    MessageBox.Show("Error al registrar el paciente");
                    return;
                }
                else
                {
                    MessageBox.Show("Paciente registrado correctamente");
                }
                Validaciones.LimpiarFormulario(formulario);
            }
        }
    }
}