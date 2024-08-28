using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoApp.Dominio
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string dni;
        public Cliente() 
        {
            nombre = "";
            apellido = "";
            dni = "";
        }
        public Cliente(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value;}
        }
        public string Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
    }
}
