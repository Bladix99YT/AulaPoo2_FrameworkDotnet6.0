namespace AtacadoConsole;

using Atacado.BD.EF.Database;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        //Criando a string de conexão com o banco de dados SQL Server.
        string connectionString = "Data Source=DESKTOP-OSE0EHK;Initial Catalog=bdAtacadoo;User=usrAtacado;Password=senha123;TrustServerCertificate=True;";
        var options = new DbContextOptionsBuilder<AtacadoContext>().UseSqlServer(connectionString).Options;
        var contexto = new AtacadoContext(options);

        
        BaseTestes Teste;
        
        
        // Teste = new CategoriaTestes(contexto);
        // Teste = new SubcategoriaTestes(contexto);
        // Teste = new ProdutoTestes(contexto);
           
        //Teste = new RegiaoTestes(contexto);
        //Teste = new EstadoTestes(contexto);
        //Teste = new CidadeTestes(contexto);

        //Teste = new AreaConhecimentoTestes(contexto);
        Teste = new BancoTestes(contexto);

        Teste.Imprimir();




        //Executando a pesquisa para obter todos os registros de Categoria.
        //Em seguida, abrindo os resultados e exibindo um por um.
       // Console.WriteLine("Executando pesquisa...");
    //     foreach (Categorium item in contexto.Categoria.ToList())
    //     {
    //         Console.WriteLine($"{item.Codigo} - {item.Descricao}");
    //     } 

    //     foreach(Regiao item in contexto.Regioes)
    //    {
    //         Console.WriteLine($"{item.CodigoRegiao} - {item.Nome}");
    //    } 

    //     foreach (Estado item in contexto.Estados)
    //    {
    //         Console.WriteLine($"{item.CodigoEstado} - {item.Nome} - {item.UF} - {item.CodigoRegiao}");
    //    }

    //      foreach (Cidade item in contexto.Cidades)
    //    {
    //         Console.WriteLine($"{item.CodigoCidade} - {item.Nome} - {item.UF} - {item.CodigoIBGE7} - {item.CodigoEstado}");
    //    }
        Console.WriteLine("Fim do programa");
        Console.ReadLine();
    }
}