using Gestão_de_equipamentos.ModuloEquipamento;

namespace Gestão_de_equipamentos.Modulo_chamado
{
    public class Chamado
    {
        public int id;
        public string titulo;
        public string descricao;
        public DateTime dataAbertura;




        public Chamado(string titulo, string descricao, DateTime dataAbertura)
        {
            this.titulo = titulo;
            this.descricao = descricao;
            this.dataAbertura = dataAbertura;
        }
    }
}
