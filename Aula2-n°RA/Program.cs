using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_n_RA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme fi = new Filme();
            Entrada en = new Entrada();
            Console.WriteLine("Escolha do filme do cliente");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.Write("Digite o título do filme: ");
            string titulo = Console.ReadLine();
            Console.Write("Qual a sinopse do filme? ");
            string sinopse = Console.ReadLine();
            Console.Write("Digite o gênero do filme: ");
            string genero = Console.ReadLine();
            Console.Write("Insira a classificação do filme: ");
            int classificacao = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("Ingresso do cliente");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.Write("Inisra o valor do ingresso: ");
            en.SetValor(double.Parse(Console.ReadLine()));
            Console.Write("Escolha a poltrona: ");
            en.SetPoltrona(int.Parse(Console.ReadLine()));
            Console.Write("Digite o dia e hora escolhidos: ");
            en.SetData(DateTime.Parse(Console.ReadLine()));
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("Detalhes do filme a ser exibido");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            fi.Receber(titulo, sinopse, genero, classificacao);
            Console.WriteLine(fi.Mostrar());
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("\nDetalhes do ingresso comprado");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("Valor a ser pago= " + en.GetValor() + "\nPoltrona= " + en.GetPoltrona()+ "\nData= " + en.GetData());

            Console.ReadKey();




        }
    }
}
