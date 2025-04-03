using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacientesCesharp.utilidades
{
    internal class Validaciones
    {
        public static Boolean ValidaFormulario(GroupBox g)  
        {
            foreach (Control c in g .Controls) {

                if (c is TextBox micampo && micampo.Text.Trim()=="")
                {
                    MessageBox.Show("El campo " + c.Tag + " es obligatorio.");
                    return false;
                }
                if (c is ComboBox combo && combo.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un elemento del combo " + c.Tag);
                    return false;
                }
            }
        }
        public static void LimpiarFormulario (GroupBox g) {
    }
}
