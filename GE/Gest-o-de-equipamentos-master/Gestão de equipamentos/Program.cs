using Gestão_de_equipamentos.ModuloEquipamento;
using Gestão_de_equipamentos.ModuloFabricante;

namespace Gestão_de_equipamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioEquipamentos repositorioEquipamento = new RepositorioEquipamentos();
            RepositorioChamado repositorioChamado = new RepositorioChamado();
            RepositorioFabricante repositorioFabricante = new RepositorioFabricante();
            
            TelaEquipamento telaEquipamento = new TelaEquipamento(repositorioEquipamento);
            telaEquipamento.repositorioEquipamento = repositorioEquipamento;

            TelaChamado telaChamado = new TelaChamado(repositorioChamado, repositorioEquipamento);
            telaChamado.repositorioChamado = repositorioChamado;
            telaChamado.repositorioEquipamento = repositorioEquipamento;

            TelaFabricante telafabricante = new TelaFabricante(repositorioFabricante);
            telafabricante.repositorioFabricante = repositorioFabricante;
            

            while (true)
            {
                char telaEscolhida = ApresentarMenuPrincipal();


                if (telaEscolhida == '1')
                {
                    char opcaoEscolhida = telaEquipamento.ApresentarMenu();

                    if (opcaoEscolhida == 'S')
                        break;

                    switch (opcaoEscolhida)
                    {
                        case '1':
                            telaEquipamento.CadastrarRegistro();
                            break;

                        case '2':
                            telaEquipamento.VisualizarRegistros(true);
                            break;

                        case '3':
                            telaEquipamento.editarEquipamento();
                            break;

                        case '4':
                            telaEquipamento.ExcluirRegistro();
                            break;
                    }
                }

                else if (telaEscolhida == '2')
                {
                    char opcaoEscolhida = telaChamado.ApresentarMenu();

                    if (opcaoEscolhida == 'S')
                        break;

                    switch (opcaoEscolhida)
                    {
                        case '1':
                            telaChamado.CadastrarRegistro();
                            break;

                        case '2':
                            telaChamado.VisualizarRegistros(true);
                            break;

                        case '3':
                            telaChamado.EditarRegistro();
                            break;

                        case '4':
                            telaChamado.ExcluirRegistro();
                            break;
                    }

                }
                if (telaEscolhida == '3')
                {
                    char opcaoEscolhida = telafabricante.ApresentarMenu();

                    if (opcaoEscolhida == 'S')
                        break;

                    switch (opcaoEscolhida)
                    {
                        case '1':
                            telafabricante.CadastrarFabricante();
                            break;

                        case '2':
                            telafabricante.VisualizarFabricantes(true);
                            break;

                        case '3':
                            telafabricante.EditarFabricante();
                            break;

                        case '4':
                            telafabricante.ExcluirFabricante();
                            break;
                    }
                }

            }
        }

        public static char ApresentarMenuPrincipal()
        {
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|        Gestão de Equipamentos        |");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();

            Console.WriteLine("1 - Controle de Equipamentos");
            Console.WriteLine("2 - Controle de Chamados");
            Console.WriteLine("3 - Controle de Fabricante");
            Console.WriteLine("S - Sair");

            Console.WriteLine();

            Console.Write("Escolha uma das opções: ");
            char opcaoEscolhida = Console.ReadLine().ToUpper()[0];

            return opcaoEscolhida;
        }
    }
}
