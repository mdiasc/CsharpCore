using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCore
{
    internal class Automovel
    {
        public string cor = "azul";
    }
    class Chamada
    {
         public static void Main(string[] args)
        {
            Automovel autoObj = new Automovel();
            Console.WriteLine(autoObj.cor);
        }
    }
}
