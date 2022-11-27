using DataApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula 4");
            //Pessoa pessoa1 = new Pessoa();
            //pessoa1.SetNome("Felipe Girardi Macedo");
            //Console.WriteLine($"Seu nome é: {pessoa1.GetNome()}");
            //pessoa1.SetIdade(18);
            //Console.WriteLine($"Sua idade é: {pessoa1.GetIdade()}");

            TiposNumericos tn = new TiposNumericos();
            //tn.Executa();

            TiposNumericos3.Executa();
            Console.ReadLine();
        }
    }
}
