namespace Gestão_de_equipamentos.ModuloEquipamento
{
    public class TelaEquipamento
    {
        public RepositorioEquipamentos repositorioEquipamento = new RepositorioEquipamentos();
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
            ExibirCabecalho();


            Equipamento equipamento = ObterDados();

            repositorioEquipamento.CadastrarEquipamento( equipamento );



            Console.WriteLine($"\nEquipamento \"{equipamento}\" cadastrado com sucesso!");
            Console.ReadLine();


        }

        public Equipamento ObterDados()
        {
            Console.WriteLine("Digite o nome do Equipamento");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o preço de aquisição do Equipamento");
            decimal preco = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o número de série do Equipamento");
            string serie = Console.ReadLine();

            Console.WriteLine("Digite o fábricante do Equipamento");
            string fabricante = Console.ReadLine();

            Console.WriteLine("Digite a data de fabricação");
            DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());

            Equipamento equipamento = new Equipamento();
            equipamento.nome = nome;
            equipamento.preco = preco;
            equipamento.serie = serie;
            equipamento.fabricante = fabricante;
            equipamento.dataFabricacao = dataFabricacao;
            return equipamento;
        }

        public void VisualizarRegistros(bool exibirCabecalho)
        {
            if (exibirCabecalho == true)
                ExibirCabecalho();


            Console.WriteLine("Visualização de Equipamentos");

            Console.WriteLine();

            Console.WriteLine(
                "{0, -10} | {1, -20} | {2, -15} | {3, -10} | {4, -20} | {5, -15}",
                "ID", "Nome", "Preço", "Número Série", "Fabricante", "Data De Dabricação");

            Equipamento[] equipamentos = repositorioEquipamento.SelecionarEquipamentos();

            for (int i = 0; i < equipamentos.Length; i++)
            {
                Equipamento e = equipamentos[i];

                if (e == null)
                    continue;

                Console.WriteLine("{0, -10} | {1, -20} | {2, -15} | {3, -10} | {4, -20} | {5, -15}",
            e.id, e.nome, e.preco.ToString("C2"), e.serie, e.fabricante, e.dataFabricacao.ToShortDateString());

                Console.ReadLine();

            }
        }

        public void editarEquipamento()
        {
            ExibirCabecalho();

            Console.WriteLine("Edição de Equipamentos");

            Console.WriteLine();

            VisualizarRegistros(false);

            Console.WriteLine("Digite o id do registro que deja selecionar:");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            Equipamento equipamentoAtualizado = ObterDados();

            bool conseguiuEditar = repositorioEquipamento.EditarEquipamento(idSelecionado, equipamentoAtualizado);

            if (!conseguiuEditar)
            {
                Console.WriteLine("Não foi possivel encontrar o registro selecionado");
                Console.ReadLine();
                return;
            }
        }

        public void ExcluirRegistro()
        {
            ExibirCabecalho();

            Console.WriteLine("Excluir Equipamento");

            Console.WriteLine();

            VisualizarRegistros(false);

            Console.WriteLine("Digite o id do registro que deja selecionar:");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            bool conseguiuExcluir = repositorioEquipamento.ExcluirEquipamento(idSelecionado);

            if (!conseguiuExcluir)
            {
                Console.WriteLine("Não foi possivel encontrar o registro selecionado");
                Console.ReadLine();
                return;

                Console.WriteLine($"\nEquipamento excluido com sucesso!");
            Console.ReadLine();
            }

        }
    }
}
