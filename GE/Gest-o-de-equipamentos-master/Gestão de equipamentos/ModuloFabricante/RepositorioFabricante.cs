namespace Gestão_de_equipamentos.ModuloFabricante
{
       public class RepositorioFabricante
    {
        private Fabricante[] fabricantes = new Fabricante[100];
        private int contadorFabricante = 0;


        public void VerFabricante(Fabricante fabricante)
        {
            fabricantes[contadorFabricante] = fabricante;
            contadorFabricante++;
        }
        public Fabricante[] SelecionarFabricante()
        {
            return fabricantes;
        }

        public Fabricante SelecionarFabricantePorId(int idSelecionado)
        {
            for (int i = 0; i < fabricantes.Length; i++)
            {
                Fabricante e = fabricantes[i];

                if (e == null)
                    continue;

                if (e.Id == idSelecionado)
                {
                    return e;
                }
            }

            return null;
        }
        public bool EditarFabricante(int idSelecionado, Fabricante fabricanteAtualizado)
        {
            Fabricante fabricanteSelecionado = SelecionarFabricantePorId(idSelecionado);

            if (fabricanteSelecionado == null)
            {
                return false;
            }


            fabricanteSelecionado.nome = fabricanteAtualizado.nome;
            fabricanteSelecionado.email = fabricanteAtualizado.email;
            fabricanteSelecionado.telefone = fabricanteAtualizado.telefone;

            return true;
        }
        public bool ExcluirFabricante(int idSelecionado)
        {

            for (int i = 0; i < fabricantes.Length; i++)
            {


                if (fabricantes[i] == null)
                    continue;

                if (fabricantes[i].Id == idSelecionado)
                {
                    fabricantes[i] = null;
                    return true;
                }
            }
            return false;
        }
    }
}
