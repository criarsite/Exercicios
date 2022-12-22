using BoxStart.Enum;
using BoxStart.Models;

internal class Program
{
    static CarroRepositorio repositorio = new CarroRepositorio();
    private static void Main(string[] args)
    { 
        Console.WriteLine("BoxStart estacionmento 24 HRs");
        string opcaoUsuario = OpcoesDoUsuario();

       #region Lista de acoes escolhido pelo usuario
         
        while(opcaoUsuario.ToUpper() != "s")
        {
            switch (opcaoUsuario)
            {
                case "1" : ListarCarros(); break;
                case "2" : InserirCarros(); break;
                case "3" : AtualizarCarros(); break;
                case "4" : RemoverCarro(); break;
                case "5" : VisualizarCarros(); break;
                case "L" : Console.Clear(); break;
                default: throw new ArgumentOutOfRangeException();
            }
            opcaoUsuario = OpcoesDoUsuario();
        }
        Console.WriteLine("Obrigado por usar  nossos serviços");
        Console.ReadLine();

    }
    #endregion
#region Metodos 
    // Metodos

    // Listar Carros
    private static void ListarCarros()
    {

        Console.WriteLine("Listar Carros");

        var lista = repositorio.Lista();
        if (lista.Count == 0)
        {
            Console.WriteLine("Nenhum veiculo estacionado");
            return;
            
        }
        foreach (var carro in lista)
        {
            
            Console.WriteLine("#ID {0}: - {1} {2}", carro.retornaId, carro.retornaPlaca(), carro.retornaPlaca());
        }

    }

    // Inserir novo carro no estacionamento
    private static void InserirCarros()
    { 
        Console.WriteLine("Inserir novo reigisto de carro");
        foreach (var carro in Enum.GetValues(typeof(Veiculo)))
        {
          Console.WriteLine("{0} - {1}", carro, Enum.GetName(typeof(Veiculo), carro));   
        }
        Console.WriteLine("Digite o tipo de carro entre as opções acima");
        int entradaTipoVeiculo = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a placa do carro");
        string entradaPlaca= Console.ReadLine();

         Console.WriteLine("Digite a marca do carro");
        string entradaMarca= Console.ReadLine();

         Console.WriteLine("Digite o modelo do carro");
        string entradaModelo= Console.ReadLine();

         Console.WriteLine("Digite a ano do carro");
        int entradaAno= int.Parse(Console.ReadLine());

        Carro novoCarro = new Carro(id: repositorio.ProximoId(),
                                    veiculo: (Veiculo)entradaTipoVeiculo,
                                    placa: entradaPlaca,
                                    marca: entradaMarca,
                                    modelo: entradaModelo,
                                    ano: entradaAno);

        repositorio.Inserir(novoCarro);                            

    }

    // Atualizar regisitro do carro
    private static void AtualizarCarros()
    {
        Console.WriteLine("Digite o ID do carro: ");
        int indiceCarro = int.Parse(Console.ReadLine());

        foreach (var carro in Enum.GetValues(typeof(Veiculo)))
        {
           Console.WriteLine("{0} - {1}", carro, Enum.GetName(typeof(Veiculo), carro));   
        }
       
         Console.WriteLine("Digite o tipo de carro entre as opções acima");
        int entradaTipoVeiculo = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a placa do carro");
        string entradaPlaca= Console.ReadLine();

         Console.WriteLine("Digite a marca do carro");
        string entradaMarca= Console.ReadLine();

         Console.WriteLine("Digite o modelo do carro");
        string entradaModelo= Console.ReadLine();

         Console.WriteLine("Digite a ano do carro");
        int entradaAno= int.Parse(Console.ReadLine());

          Carro atualizaCarro = new Carro(id: indiceCarro,
                                    veiculo: (Veiculo)entradaTipoVeiculo,
                                    placa: entradaPlaca,
                                    marca: entradaMarca,
                                    modelo: entradaModelo,
                                    ano: entradaAno);

        repositorio.Atualizar(indiceCarro, atualizaCarro);                          


    }


// Visualizar Carro
private static void VisualizarCarros()
{
    Console.WriteLine("Digite o Id do Carro");
    int indiceCarro = int.Parse(Console.ReadLine());

    var carro = repositorio.RetornaPorId(indiceCarro);
     
     Console.WriteLine(carro);

}

// remover carro
private static void RemoverCarro()
{
    Console.WriteLine("Digite o id do carro");
    int indiceCarro = int.Parse(Console.ReadLine());

  
    repositorio.Excluir(indiceCarro);
}

#endregion

    #region  Opcoes Menu para o usuario 
        private static string OpcoesDoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Estacionamento 24 hrs: BoxStart");
            Console.WriteLine("Informe uma opção");

            Console.WriteLine("1 - Listar carros");
            Console.WriteLine("2 - Inserir novo carro");
            Console.WriteLine("3 - Atualizar registro");
            Console.WriteLine("4 - Remover veiculo");
            Console.WriteLine("5 - Visualizar carro");

            Console.WriteLine("L - Limpar Tela");
            Console.WriteLine("S - Para sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
        #endregion
    
}