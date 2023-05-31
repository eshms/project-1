using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            yilan snake = new yilan();
            yem yem = new yem();
            yem.uret();
            ConsoleKeyInfo basilantus;
            do
            {
                basilantus = Console.ReadKey();
                snake.hareket(basilantus);
                snake.ciz();
                yem.ciz();
                if (snake.yemiyedimi(yem) == true)
                {
                    yem.uret();
                    snake.ciz();
                }
                snake.skoryaz();
               

            } while (basilantus.Key != ConsoleKey.Escape);




        }
    }
}
