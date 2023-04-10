using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class BancoTestes : BaseTestes
{
    public BancoTestes(AtacadoContext contexto) : base(contexto)
    { }

    public override void Imprimir()
    {
        Console.WriteLine("--- EXIBINDO BANCOS ---");
        foreach (Banco item in context.Bancos)
        {
            Console.WriteLine($"{item.CodigoBanco} - {item.Descricao}");
        }

        Console.WriteLine("--- Finalizando Bancos ---");
        Console.ReadLine(); 
    }
}
