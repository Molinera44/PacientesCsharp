using PacientesCesharp.vistas;
using System.Windows.Forms;

namespace PacientesCesharp
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonEnter = new System.Windows.Forms.Button();
            this.campoPass = new System.Windows.Forms.TextBox();
            this.campoUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PacientesCesharp.Properties.Resources.salud;
            this.pictureBox1.Location = new System.Drawing.Point(448, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 77);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 26);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botonEnter);
            this.groupBox1.Controls.Add(this.campoPass);
            this.groupBox1.Controls.Add(this.campoUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 217);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGIN";
            // 
            // botonEnter
            // 
            this.botonEnter.Location = new System.Drawing.Point(153, 168);
            this.botonEnter.Name = "botonEnter";
            this.botonEnter.Size = new System.Drawing.Size(82, 26);
            this.botonEnter.TabIndex = 3;
            this.botonEnter.Text = "Entrar";
            this.botonEnter.UseVisualStyleBackColor = true;
            this.botonEnter.Click += new System.EventHandler(this.botonEnter_Click);
            // 
            // campoPass
            // 
            this.campoPass.Location = new System.Drawing.Point(177, 113);
            this.campoPass.Name = "campoPass";
            this.campoPass.Size = new System.Drawing.Size(148, 20);
            this.campoPass.TabIndex = 2;
            this.campoPass.UseSystemPasswordChar = true;
            this.campoPass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // campoUser
            // 
            this.campoUser.Location = new System.Drawing.Point(177, 60);
            this.campoUser.Name = "campoUser";
            this.campoUser.Size = new System.Drawing.Size(148, 20);
            this.campoUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox campoPass;
        private System.Windows.Forms.TextBox campoUser;
        private System.Windows.Forms.Button botonEnter;


        public void Acceso ()
        {
            string user;
            string pass;

            user = campoUser.Text;
            pass = utilidades.Encriptado.Encriptar(campoPass.Text);

            if(bbdd.conexion.Acceder(user, pass))
            {
                Principal p = new Principal();
                p.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show(this, "Logado incorrecto");
                campoUser.Text="";
                campoPass.Text="";
            }
        }
    }
}

