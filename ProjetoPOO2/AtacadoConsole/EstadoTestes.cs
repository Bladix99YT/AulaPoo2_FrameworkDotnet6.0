using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class EstadoTestes : BaseTestes
{
    public EstadoTestes(AtacadoContext contexto) : base(contexto)
    { }

    public override void Imprimir()
    {
        Console.WriteLine("--- EXIBINDO ESTADOS ---");
        foreach (Estado item in context.Estados)
        {
            Console.WriteLine($"{item.CodigoRegiao}- {item.UF} - {item.Nome}");
        }

        Console.WriteLine("--- Finalizando Regiões ---");
        Console.ReadLine(); 
    }
}
