using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculaListaAPI.DTO
{
    public class RetListaCalculadaDTO
    {
        public RetListaCalculadaDTO()
        {

        }

        public int SomaTotalLista { get; set; }
        public int SomaParesLista { get; set; }
        public decimal MediaLista { get; set; }
        public int MaiorNumeroLista { get; set; }
        public int MenorNumeroLista { get; set; }
    }
}
