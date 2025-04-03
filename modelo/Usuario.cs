using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacientesCesharp.modelo
{
    internal class Usuario
    {
        private int id;
        private string nombrecompleto;
        private string usuarios;
        private string pass;

        public Usuario(int id, string nombrecompleto, string usuario, string pass)
        {
            this.Id = id;
            this.Nombrecompleto = nombrecompleto;
            this.Usuarios = usuario;
            this.Pass = pass;
        }

        public int Id { get => id; set => id = value; }
        public string Nombrecompleto { get => nombrecompleto; set => nombrecompleto = value; }
        public string Usuarios { get => usuarios; set => usuarios = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}
