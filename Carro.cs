using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CsharpCore
{
    internal class Carro
    {
        //Declarando variáveis de dois tipos de entrada
        String modelo = "1600", fabricante = "Volkswagen", cor = "Azul", nome = "Fusca";
        int ano = 1974;

        public static void Main(String[] args)
        {
            Carro carro01 = new Carro();
            Carro carro02 = new Carro();

            Console.WriteLine(carro01.modelo);
            Console.WriteLine(carro02.modelo);
            Console.WriteLine(carro01.fabricante);
            Console.WriteLine(carro02.fabricante);
            Console.WriteLine(carro01.cor);
            Console.WriteLine(carro02.cor);
            Console.WriteLine(carro01.nome);
            Console.WriteLine(carro02.nome);
            Console.WriteLine(carro01.ano);
            Console.WriteLine(carro02.ano);
        }
    }
}
