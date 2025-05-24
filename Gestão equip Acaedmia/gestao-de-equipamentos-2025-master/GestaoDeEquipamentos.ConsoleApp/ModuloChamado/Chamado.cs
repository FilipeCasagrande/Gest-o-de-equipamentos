using System.Net.Mail;
using GestaoDeEquipamentos.ConsoleApp.Compartilhado;
using GestaoDeEquipamentos.ConsoleApp.ModuloEquipamento;

namespace GestaoDeEquipamentos.ConsoleApp.ModuloChamado;

public class Chamado : EntidadeBase
{
    public int id;
    public string titulo;
    public string descricao;
    public DateTime dataAbertura;

    public Equipamento equipamento;

    public override void AtualizarRegistro(EntidadeBase registroAtualizado)
    {
        Chamado chamadoAtualizado = (Chamado)registroAtualizado;

        this.titulo = chamadoAtualizado.titulo;
        this.descricao = chamadoAtualizado.descricao;
        this.dataAbertura = chamadoAtualizado.dataAbertura;
        this.equipamento = chamadoAtualizado.equipamento;

    }
    public override string Validar()
    {
        string erros = "";

        if (string.IsNullOrWhiteSpace(titulo))
        {
            erros += "O campo Titulo é obrigatório";
        }

        else if (titulo.Length < 3) 
        {
            erros += "O campo titulo deve conter mais que 3 caracteres";
        }

        if (string.IsNullOrWhiteSpace(descricao))
        {
            erros += "O campo descreição é obrigatório";
        }
        if(equipamento == null)
        {
            erros += "O campo equipamentos é obrigatório.\n";
        }
        return erros;
    }

}
