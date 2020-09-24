using CalculaListaAPI.DTO;
using System;
using System.Collections.Generic;

namespace CalculaListaAPI.BO
{
    public class CalculaListaBO
    {
        public static RetListaCalculadaDTO RetornaCalculosLista(List<int> listaNumeros)
        {
            try
            {
                RetListaCalculadaDTO ret = new RetListaCalculadaDTO();

                ret.MaiorNumeroLista = CalculaMaiorNumeroLista(listaNumeros);
                ret.MenorNumeroLista = CalculaMenorNumeroLista(listaNumeros);
                ret.SomaTotalLista = CalculaValorSomaLista(listaNumeros);
                ret.SomaParesLista = CalculaSomaParesLista(listaNumeros);
                ret.MediaLista = CalculaValorMediaLista(ret.SomaTotalLista, listaNumeros.Count);

                return ret;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static int CalculaMaiorNumeroLista(List<int> listaNumeros)
        {
            int maior = 0;

            foreach (int num in listaNumeros)
            {
                if (num > maior)
                {
                    maior = num;
                }
            }

            return maior;
        }

        private static int CalculaMenorNumeroLista(List<int> listaNumeros)
        {
            int menor = int.MaxValue;

            foreach (int num in listaNumeros)
            {
                if (num < menor)
                {
                    menor = num;
                }
            }

            return menor;
        }

        private static decimal CalculaValorMediaLista(int somaTotal, int totalNumeros)
        {
            return (somaTotal / totalNumeros);
        }

        private static int CalculaValorSomaLista(List<int> listaNumeros)
        {
            int totalLista = 0;

            foreach (var num in listaNumeros)
            {
                totalLista += num;
            }

            return totalLista;
        }

        private static int CalculaSomaParesLista(List<int> listaNumeros)
        {
            int totalPares = 0;

            foreach (var num in listaNumeros)
            {
                if (num%2 == 0)
                {
                    totalPares += num;
                }
            }

            return totalPares;
        }

    }
}
