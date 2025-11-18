
using AtividadePolimorfismo;

internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario f = new Funcionario(1, "João", 1500);
        Console.WriteLine($" \nBonificação funcionário {f.Nome}: {f.CalcularBonificacao():C}");

        Funcionario f2 = new Funcionario(2, "Bruno", 2000);
        Console.WriteLine($"Bonificação Funcionário 2 {f2.Nome}: {f2.CalcularBonificacao():C}");

        Secretario s = new Secretario(3, "Ricardo", 1400);
        Console.WriteLine($"Bonificação Secretário {s.Nome} {s.CalcularBonificacao():C}");

        Secretario s2 = new Secretario(4, "João", 1800);
        Console.WriteLine($"Bonificação Secretário 2 {s2.Nome}: {s2.CalcularBonificacao():C}");

        Gerente g = new Gerente(5, "José", 7000);
        Console.WriteLine($"Bonificação Gerente {g.Nome}: {g.CalcularBonificacao():C}");

        Diretor d = new Diretor(6, "Bruno", 1000);
        Console.WriteLine($"Bonificação Diretor {d.Nome}: {d.CalcularBonificacao():C}");


        GerenciadorBonificacao b = new GerenciadorBonificacao();
        b.TotalizadorBonificacao(f);
        b.TotalizadorBonificacao(f2);
        b.TotalizadorBonificacao(s);
        b.TotalizadorBonificacao(s2);
        b.TotalizadorBonificacao(g);
        b.TotalizadorBonificacao(d);
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine($"Valor total de Bonificações a pagar: {b.TotaldeBonificacao:C}");
        Console.WriteLine("-------------------------------------------------");
    }
}