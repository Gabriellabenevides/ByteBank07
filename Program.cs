namespace ByteBank7;

class Program
{
    static void Main(string[] args)
    {
        ContaCorrente conta = new ContaCorrente(867, 86712540);

        Console.WriteLine(ContaCorrente.TotalDeContasCriadas);



        Console.WriteLine(conta.Agencia);
        Console.WriteLine(conta.Numero);

        ContaCorrente contaDaGabriela = new ContaCorrente(867, 86712540);
        Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

        
    }
}