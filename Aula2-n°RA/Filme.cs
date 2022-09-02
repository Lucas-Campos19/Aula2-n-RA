using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_n_RA
{
    internal class Filme
    {
        string titulo;
        string sinopse;
        string genero;
        int classificacao;

        public void Receber(string ti, string si, string ge, int cla)
        {
            this.titulo = ti;
            this.sinopse = si;
            this.genero = ge;
            this.classificacao = cla;
        }
        public string Mostrar()
        {
            return "Título= " + this.titulo + "\nSinopse= " + this.sinopse + "\nGenero=" + this.genero + "\nClassificação= " + this.classificacao;
        }
    }
}
