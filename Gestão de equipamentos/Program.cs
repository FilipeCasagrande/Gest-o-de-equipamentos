namespace Gestão_de_equipamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaEquipamento telaEquipamento = new TelaEquipamento();

            while (true)
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
        }
    }
}
