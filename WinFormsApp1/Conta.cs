using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Conta
    {
        public int Numero { get; set; }
        private double Saldo { get; set; }

        public Cliente Cliente { get; set; }

        public Conta(Cliente cliente)
        {
            Cliente = cliente;
            Saldo = 0;
        }

        public virtual void Transferir(Conta contaDestino, Conta contaOrigem)
        {

        }

        public virtual void Depositar (double valor) 
        {
            Saldo += valor;
        }

        public virtual void Sacar (double valor) 
        {
            Saldo -= valor;
        }
    }
}
