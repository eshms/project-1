using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class yem
    {
        public int x, y;
        public char chr = '*';
        public void uret()
        {
            Random sayiGen = new Random();
            x = sayiGen.Next(1, 31);
            y = sayiGen.Next(1, 21);    

        }
        public void ciz()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(chr);
        }

    }
}

