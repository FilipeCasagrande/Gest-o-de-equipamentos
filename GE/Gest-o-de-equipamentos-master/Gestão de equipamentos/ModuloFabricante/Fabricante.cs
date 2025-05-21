

namespace Gestão_de_equipamentos.ModuloFabricante
{
    public class Fabricante
    {
        public int Id;
        public string nome;
        public string email;
        public string telefone;


        public Fabricante(string nome, string email, string telefone)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;

        }
    }
}
