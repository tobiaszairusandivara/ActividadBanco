using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoApp.Datos
{
    public interface IRepositorios
    {
        bool Crear(object elemento);
        object Leer();
        bool Modificar();
        bool Eliminar();
    }
}
