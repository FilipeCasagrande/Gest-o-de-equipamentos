using Gestão_de_equipamentos.ModuloFabricante;

namespace Gestão_de_equipamentos.ModuloEquipamento
{
    public class Equipamento
    {
        public int id;
        public string nome;
        public decimal preco;
        public string fabricante;
        public string serie;
        public DateTime dataFabricacao;


        public Equipamento (string nome, decimal preco, string fabricante, string serie, DateTime dataFabricacao)
        {
            this.nome = nome;
            this.preco = preco;
            this.serie = serie;
            this.fabricante = fabricante;
            this.dataFabricacao = dataFabricacao;

        }

    }
}
