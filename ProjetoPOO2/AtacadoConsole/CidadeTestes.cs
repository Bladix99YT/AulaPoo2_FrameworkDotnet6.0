using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class CidadeTestes : BaseTestes
{
    public CidadeTestes(AtacadoContext contexto) : base(contexto)
    { }

    public override void Imprimir()
    {
        Console.WriteLine("--- EXIBINDO CIDADES ---");
        foreach (Cidade item in context.Cidades)
        {
            Console.WriteLine($"{item.CodigoEstado}- {item.CodigoCidade} - {item.UF} - {item.Nome}");
        }

        Console.WriteLine("--- Finalizando Cidades ---");
        Console.ReadLine(); 
    }
}