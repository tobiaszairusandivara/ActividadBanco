using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoApp.Dominio
{
    public class Cuenta
    {
        private string cbu;
        private double saldo;
        private TipoDeCuenta tdc;
        private DateTime ultimoMovimiento;
        private Cliente dueño;
        public Cuenta()
        {
            cbu = "";
            saldo = 0;
            tdc= new TipoDeCuenta();
            ultimoMovimiento = DateTime.Now;
            dueño= new Cliente();
        }
        public Cuenta(string cbu, double saldo, TipoDeCuenta tdc, DateTime ultimoMovimiento, Cliente dueño)
        {
            this.cbu = cbu;
            this.saldo = saldo;
            this.tdc = tdc;
            this.ultimoMovimiento = ultimoMovimiento;
            this.dueño = dueño;
        }
        public string Cbu
        {
            get { return cbu; }
            set { cbu = value; }
        }
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public TipoDeCuenta Tdc
        {
            get { return tdc; }
            set { tdc = value; }
        }
        public DateTime UltimoMovimiento
        {
            get { return ultimoMovimiento; }
            set { ultimoMovimiento = value; }
        }
        public Cliente Dueño
        {
            get { return this.dueño; }
            set { dueño= value; }
        }
    }
}
