using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class RegiaoTestes : BaseTestes
{
    public RegiaoTestes(AtacadoContext contexto) : base(contexto)
    { }

    public override void Imprimir()
    {
        Console.WriteLine("--- EXIBINDO REGIÕES ---");
        foreach (Regiao item in context.Regioes)
        {
            Console.WriteLine($"{item.CodigoRegiao} - {item.Nome}");
        }

        Console.WriteLine("--- Finalizando Regiões ---");
        Console.ReadLine(); 
    }
}
