using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class AreaConhecimentoTestes : BaseTestes
{
    public AreaConhecimentoTestes(AtacadoContext contexto) : base(contexto)
    { }

    public override void Imprimir()
    {
        Console.WriteLine("--- EXIBINDO AREAS ---");
        foreach (AreaConhecimento item in context.Areas)
        {
            Console.WriteLine($"{item.CodigoArea} - {item.DataInclusao} - {item.Descricao}");
        }

        Console.WriteLine("--- Finalizando Areas ---");
        Console.ReadLine(); 
    }
}
