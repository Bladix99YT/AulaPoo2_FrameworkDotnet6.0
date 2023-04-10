using Atacado.BD.EF.Database;

namespace AtacadoConsole;

public class ProdutoTestes : BaseTestes
{
    public ProdutoTestes(AtacadoContext contexto) : base(contexto)
    { }

    public override void Imprimir()
    {
        Console.WriteLine("--- EXIBINDO PRODUTOS ---");
        foreach (Produto item in context.Produtos)
        {
            Console.WriteLine($"{item.Codigo} - {item.CodigoSubcategoria} - {item.Descricao} - {item.Valor}");
        }

        Console.WriteLine("--- Finalizando Produtos ---");
        Console.ReadLine(); 
    }
}
