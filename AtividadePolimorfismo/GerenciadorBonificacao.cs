using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePolimorfismo
{
    public class GerenciadorBonificacao
    {
        public double TotaldeBonificacao { get; private set; } =0;
        public void TotalizadorBonificacao(Diretor diretor)
        {
            this.TotaldeBonificacao += diretor.CalcularBonificacao();
        }
        public void TotalizadorBonificacao(Gerente gerente)
        {
            this.TotaldeBonificacao += gerente.CalcularBonificacao();
        }
        public void TotalizadorBonificacao(Secretario secretario)
        {
            this.TotaldeBonificacao += secretario.CalcularBonificacao();
        }
        public void TotalizadorBonificacao(Funcionario funcionario)
        {
            this.TotaldeBonificacao += funcionario.CalcularBonificacao();
        }
    }
}