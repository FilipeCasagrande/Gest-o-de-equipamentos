
using Gestão_de_equipamentos.ModuloEquipamento;

namespace Gestão_de_equipamentos.ModuloChamado
{
    class TelaChamado
    {
        public void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine();
        }

        public char ApresentarMenu()
        {
            ExibirCabecalho();

            Console.WriteLine("1 - Cadastro de Equipamentos");
            Console.WriteLine("2 - Visualizar Equipamentos");
            Console.WriteLine("3 - Editar Equipamentos");
            Console.WriteLine("4 - Excluir Equipamento");
            Console.WriteLine("S - Sair");

            Console.WriteLine();

            Console.Write("Digite uma opção válida: ");
            char opcaoEscolhida = Console.ReadLine().ToUpper()[0];

            return opcaoEscolhida;
        }


        public void CadastrarRegistro()
        {
            public void CadastrarRegistro()
        {
            ExibirCabecalho();
            Equipamento equipamento = ObterDados();

            repositorioEquipamento.CadastrarEquipamento(equipamento);

            Console.WriteLine($"\nEquipamento \"{equipamento}\" cadastrado com sucesso!");
            Console.ReadLine();
        }
        }

        public void editarEquipamento()
        {

        }

        public void ExcluirRegistro()
        {

        }

        public void VisualizarRegistros(bool v)
        {

        }
    }
}
