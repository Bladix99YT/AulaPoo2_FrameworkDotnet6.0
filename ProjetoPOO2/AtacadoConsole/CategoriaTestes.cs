using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class CategoriaTestes : BaseTestes
{
    public CategoriaTestes(AtacadoContext contexto) : base(contexto)
    { }

    public override void Imprimir()
    {
        Console.WriteLine("--- EXIBINDO CATEGORIAS ---");
        foreach (Categoria item in context.Categorias)
        {
            Console.WriteLine($"{item.Codigo} - {item.Descricao}");
        }

        Console.WriteLine("--- Finalizando Categorias ---");
        Console.ReadLine(); 
    }
}
