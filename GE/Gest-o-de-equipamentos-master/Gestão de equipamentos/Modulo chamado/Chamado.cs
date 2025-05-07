using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestão_de_equipamentos.ModuloEquipamento;

namespace Gestão_de_equipamentos.Modulo_chamado
{
    class Chamado
    {
        public int id;
        public string titulo;
        public string descricao;
        public DateTime dataAbertura;

        public Equipamento equipamento;
    }
}
