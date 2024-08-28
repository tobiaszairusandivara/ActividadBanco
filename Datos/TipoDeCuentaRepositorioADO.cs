using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoApp.Datos
{
    public class TipoDeCuentaRepositorioADO: IRepositorios
    {
        private DataHelper dh;
        public TipoDeCuentaRepositorioADO()
        {
            dh = DataHelper.ConseguirInstancia();    
        }
        public bool Crear(object elemento)
        {
            throw new NotImplementedException();
        }

        public object Leer()
        {
            throw new NotImplementedException();
        }

        public bool Modificar()
        {
            throw new NotImplementedException();
        }

        public bool Eliminar()
        {
            throw new NotImplementedException();
        }
    }
}
