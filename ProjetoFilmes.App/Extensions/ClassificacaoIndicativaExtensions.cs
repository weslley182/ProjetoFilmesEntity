using ProjetoFilmes.App.Enumerado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFilmes.App.Extensions
{
    public static class ClassificacaoIndicativaExtensions
    {
        private static Dictionary<string, ClassificacaoIndicativa> mapa = new Dictionary<string, ClassificacaoIndicativa>
    {
        { "G", ClassificacaoIndicativa.Livre },
        { "PG", ClassificacaoIndicativa.MaiorQue10 },
        { "PG-13", ClassificacaoIndicativa.MaiorQue13 },
        { "R", ClassificacaoIndicativa.MaiorQue14 },
        { "NC-17", ClassificacaoIndicativa.MaiorQue18 }
    };

        public static string ParaString(this ClassificacaoIndicativa valor)
        {
            return mapa.First(c => c.Value == valor).Key;
        }

        public static ClassificacaoIndicativa ParaValor(this string texto)
        {
            return mapa.First(c => c.Key == texto).Value;
        }
    }
}

