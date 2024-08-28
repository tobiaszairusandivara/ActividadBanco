namespace BancoApp.Dominio
{
    public class TipoDeCuenta
    {
        private string nombre;
        public TipoDeCuenta() 
        {
            nombre = "";
        }
        public TipoDeCuenta(string nombre)
        {
            this.nombre = nombre;
        }
        public string Nombre { get { return nombre; } set {this.nombre = value; } }
        public override string ToString()
        {
            return nombre;
        }
    }
}
