using System.Runtime.CompilerServices;
using Gestão_de_equipamentos.ModuloEquipamento;

namespace Gestão_de_equipamentos.ModuloFabricante
{
    public class TelaFabricante
    {
        public RepositorioFabricante repositorioFabricante;

        public TelaFabricante(RepositorioFabricante repositorioF)
        {
            repositorioFabricante = repositorioF;
        }
        public void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Fabricantes");
            Console.WriteLine();
        }

        public char ApresentarMenu()
        {
            ExibirCabecalho();

            Console.WriteLine("1 - Registrar Fabricante");
            Console.WriteLine("2 - Visualizar Fabricantes");
            Console.WriteLine("3 - Editar Fabricantes");
            Console.WriteLine("4 - Excluir Fabricante");
            Console.WriteLine("S - Sair");

            Console.WriteLine();

            Console.Write("Digite uma opção válida: ");
            char opcaoEscolhida = Console.ReadLine().ToUpper()[0];

            return opcaoEscolhida;
        }

        public void CadastrarFabricante()
        {
            ExibirCabecalho();


            Fabricante fabricante = ObterDados();

            repositorioFabricante.VerFabricante(fabricante);

            Console.WriteLine($"Fabricante {fabricante.nome} registrado com sucesso!");
            Console.ReadLine();

        }

        private Fabricante ObterDados()
        {
            Console.WriteLine("Digite o nome do Fabricante");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o E-Mail do Fabricante");
            string email = Console.ReadLine();

            Console.WriteLine("Digite o número do Fabricante");
            string telefone = Console.ReadLine();

            Fabricante fabricante = new Fabricante(nome, email , telefone);
            
            return fabricante;
        }

        public void VisualizarFabricantes(bool exibirCabecalho)
        {
            if (exibirCabecalho == true)
                ExibirCabecalho();

            Console.WriteLine("Visualização de Fabricantes");

            Console.WriteLine();

            Console.WriteLine(
                "{0, -10} | {1, -20} | {2, -15} | {3, -10}",
                "ID", "Nome", "E-mail", "Número Telefone");

            Fabricante[] fabricantes = repositorioFabricante.SelecionarFabricante();

            for (int i = 0; i < fabricantes.Length; i++)
            {
                Fabricante f = fabricantes[i];

                if (f == null)
                    continue;

                Console.WriteLine("{0, -10} | {1, -20} | {2, -15} | {3, -10}",
             f.Id, f.nome, f.email, f.telefone);

                Console.ReadLine();
            }
        }

        public void EditarFabricante()
        {
            ExibirCabecalho();

            Console.WriteLine("Edição de Equipamentos");

            Console.WriteLine();

            VisualizarRegistros(false);

            Console.WriteLine("Digite o id do registro que deja selecionar:");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            Fabricante fabricanteAtualizado = ObterDados();

            bool conseguiuEditar = repositorioFabricante.EditarFabricante(idSelecionado, fabricanteAtualizado);

            if (!conseguiuEditar)
            {
                Console.WriteLine("Não foi possivel encontrar o registro selecionado");
                Console.ReadLine();
                return;
            }
        }
        public void VisualizarRegistros(bool exibirCabecalho)
        {
            if (exibirCabecalho == true)
                ExibirCabecalho();


            Console.WriteLine("Visualização de Fabricantes");

            Console.WriteLine();

            Console.WriteLine(
                "{0, -10} | {1, -20} | {2, -15} | {3, -10}",
                "ID", "Nome", "E-mail", "Número Telefone");

            Fabricante[] fabricantes = repositorioFabricante.SelecionarFabricante();

            for (int i = 0; i < fabricantes.Length; i++)
            {
                Fabricante f = fabricantes[i];

                if (f == null)
                    continue;

                Console.WriteLine("{0, -10} | {1, -20} | {2, -15} | {3, -10}",
             f.Id, f.nome, f.email, f.telefone);

                Console.ReadLine();

            }
        }
        public void ExcluirFabricante()
        {
            ExibirCabecalho();

            Console.WriteLine("Excluir Equipamento");

            Console.WriteLine();

            VisualizarRegistros(false);

            Console.WriteLine("Digite o id do registro que deja selecionar:");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            bool conseguiuExcluir = repositorioFabricante.ExcluirFabricante(idSelecionado);

            if (!conseguiuExcluir)
            {
                Console.WriteLine("Não foi possivel encontrar o registro selecionado");
                Console.ReadLine();
                return;
            }
                Console.WriteLine($"\nEquipamento excluido com sucesso!");
                Console.ReadLine();
            
        }
    }
}
