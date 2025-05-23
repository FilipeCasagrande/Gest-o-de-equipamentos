﻿
using GestaoDeEquipamentos.ConsoleApp.Compartilhado;
using GestaoDeEquipamentos.ConsoleApp.ModuloEquipamento;
using GestaoDeEquipamentos.ConsoleApp.ModuloFabricante;

namespace GestaoDeEquipamentos.ConsoleApp.ModuloChamado;

public class TelaChamado : TelaBase
{
    public RepositorioEquipamento repositorioEquipamento;
    public RepositorioChamado repositorioChamado;

    public TelaChamado(RepositorioChamado repositorioC) : base("Chamado", repositorioC)
    {
        repositorioChamado = repositorioC;
    }

    public void EditarRegistro()
    {
        ExibirCabecalho();

        Console.WriteLine("Edição de Chamados");

        Console.WriteLine();

        VisualizarRegistros(false);

        Console.Write("Digite o id do registro que deseja selecionar: ");
        int idSelecionado = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Chamado chamadoAtualizado = ObterDados();

        bool conseguiuEditar = repositorioChamado.EditarRegistro(idSelecionado, chamadoAtualizado);

        if (!conseguiuEditar)
        {
            Console.WriteLine("Não foi possível encontrar o registro selecionado.");
            Console.ReadLine();

            return;
        }

        Console.WriteLine($"\nChamado \"{chamadoAtualizado.titulo}\" editado com sucesso!");
        Console.ReadLine();
    }

    public void ExcluirRegistro()
    {
        ExibirCabecalho();

        Console.WriteLine("Exclusão de Chamados");

        Console.WriteLine();

        VisualizarRegistros(false);

        Console.Write("Digite o id do registro que deseja selecionar: ");
        int idSelecionado = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        bool conseguiuExcluir = repositorioChamado.ExcluirRegistro(idSelecionado);

        if (!conseguiuExcluir)
        {
            Console.WriteLine("Não foi possível encontrar o registro selecionado.");
            Console.ReadLine();

            return;
        }

        Console.WriteLine($"\nChamado excluído com sucesso!");
        Console.ReadLine();
    }

    public void VisualizarRegistros(bool exibirCabecalho)
    {
        if (exibirCabecalho == true)
            ExibirCabecalho();

        Console.WriteLine("Visualização de Chamados");

        Console.WriteLine();

        Console.WriteLine(
            "{0, -10} | {1, -20} | {2, -15} | {3, -15} | {4, -20}",
            "Id", "Título", "Descrição", "Data de Abertura", "Equipamento"
        );

        EntidadeBase[] chamados = repositorioChamado.SelecionarRegistros();

        for (int i = 0; i < chamados.Length; i++)
        {
            Chamado c = (Chamado)chamados[i];

            if (c == null)
                continue;

            Console.WriteLine(
                "{0, -10} | {1, -20} | {2, -15} | {3, -15} | {4, -20}",
                c.id, c.titulo, c.descricao, c.dataAbertura.ToShortDateString(), c.equipamento.nome
            );
        }

        Console.ReadLine();
    }

    protected override Chamado ObterDados()
    {
        Console.Write("Digite o título do chamado: ");
        string titulo = Console.ReadLine();

        Console.Write("Digite a descrição do chamado: ");
        string descricao = Console.ReadLine();

        DateTime dataAbertura = DateTime.Now;

        VisualizarEquipamentos();

        Console.Write("Digite o ID do equipamento que deseja selecionar: ");
        int idEquipamento = Convert.ToInt32(Console.ReadLine());

        Equipamento equipamentoSelecionado = (Equipamento)repositorioEquipamento.SelecionarRegistroPorId(idEquipamento);

        Chamado chamado = new Chamado();
        chamado.titulo = titulo;
        chamado.descricao = descricao;
        chamado.dataAbertura = dataAbertura;
        chamado.equipamento = equipamentoSelecionado;

        return chamado;
    }

    public void VisualizarEquipamentos()
    {
        Console.WriteLine();

        Console.WriteLine("Visualização de Equipamentos");

        Console.WriteLine();

        Console.WriteLine(
            "{0, -10} | {1, -20} | {2, -15} | {3, -15} | {4, -20} | {5, -15}",
            "Id", "Nome", "Preço Aquisição", "Número Série", "Fabricante", "Data Fabricação"
        );

        EntidadeBase[] equipamentos = repositorioEquipamento.SelecionarRegistros();

        for (int i = 0; i < equipamentos.Length; i++)
        {
            Equipamento e = (Equipamento)equipamentos[i];

            if (e == null)
                continue;

            Console.WriteLine(
                "{0, -10} | {1, -20} | {2, -15} | {3, -15} | {4, -20} | {5, -15}",
                e.id, e.nome, e.precoAquisicao.ToString("C2"), e.numeroSerie, e.fabricante.nome, e.dataFabricacao.ToShortDateString()
            );
        }

        Console.ReadLine();
    }
}
