using PacientesCesharp.bbdd;
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
    public partial class TablaPacientes : Form
    {
        public TablaPacientes()
        {
            InitializeComponent();
            dataGridView1.DataSource = conexion.CargaPacientes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
