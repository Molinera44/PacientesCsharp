using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacientesCesharp.vistas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaPacientes ap = new AltaPacientes();
            ap.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AltaUsuarios au = new AltaUsuarios();
            au.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TablaPacientes tp = new TablaPacientes();
            tp.Show();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
