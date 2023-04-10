using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class SubcategoriaTestes : BaseTestes
{
    public SubcategoriaTestes(AtacadoContext contexto) : base(contexto)
    { }

    public override void Imprimir()
    {
        Console.WriteLine("--- EXIBINDO SUBCATEGORIAS ---");
        foreach (Subcategoria item in context.Subcategorias)
        {
            Console.WriteLine($"{item.Codigo} - {item.CodigoCategoria} - {item.Descricao}");
        }

        Console.WriteLine("--- Finalizando SubCategorias ---");
        Console.ReadLine(); 
    }
}
