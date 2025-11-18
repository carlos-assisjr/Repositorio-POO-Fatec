using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePolimorfismo
{
    public class Diretor : Funcionario
    {
        // a palavra base () chama o construtor da superclasse
        public Diretor(int codigo, string nome, double salario) : base(codigo, nome, salario)
        {
        }
        public override double CalcularBonificacao()
        {// a palavra base chama o método que está na superclasse
         // calcula 10% e retorna o valor, para então, ser somado a 1000
            return base.CalcularBonificacao() + 1000;
        }
    }
}