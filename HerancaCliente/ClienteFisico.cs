using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{//            classe derivada : classe base/superclasse
    public class ClienteFisico : Cliente
    {
        private int rg;
        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        public void Mostrar()
        { // codigo minúsculo tem o modificador de 
          // acesso/visibilidade aberto para acessar 
          // a superclasse, pela palavra 
          // reservada protected
            Console.WriteLine($"Código: {codigo} \tNome: {nome} \tRg: {Rg}");
        }         
    }
}