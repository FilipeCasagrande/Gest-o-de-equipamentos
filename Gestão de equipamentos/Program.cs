using System.ComponentModel.Design;
using Gestão_de_equipamentos.ModuloChamado;
using Gestão_de_equipamentos.ModuloEquipamento;

namespace Gestão_de_equipamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaEquipamento telaEquipamento = new TelaEquipamento();
            TelaChamado telaChamado = new TelaChamado();

            while (true)
            {
                char telaEscolhida = '2';

                if (telaEscolhida == '1')
                {
                    char opcaoEscolhida = telaEquipamento.ApresentarMenu();

                if (opcaoEscolhida == 'S')
                        break;

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
                        telaChamado.editarEquipamento();
                        break;

                    case '4':
                        telaChamado.ExcluirRegistro();
                        break;
                }
                }
                    

                





            }
        }
    }
}
