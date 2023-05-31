using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class yilan
    {
        public int x, y;
        public char chr = 's';

        int skor = 0;


        public void ciz()
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write(chr);
        }

        public void hareket(ConsoleKeyInfo basilantus)
        {   //basilantus sağ ok ise x++
            //basilan tus sol ok ise x--
            //basilan tus asaği ok ise y++
            //basilan tus yukarı ok ise y--
            if (basilantus.Key == ConsoleKey.RightArrow)
                x++;
            else if (basilantus.Key == ConsoleKey.LeftArrow)
                x--;
            else if (basilantus.Key == ConsoleKey.DownArrow)
                y++;
            else
                y--;
            //oyun alanı x:[1,30], y:[1,20] geçmişse oyun alanına tasi
            if (y == 21)
                y = 1;
            if (x == 31)
                x = 1;
            if (y == 0)
                y = 20;
            if (x == 0)
                x = 30;

        }
        public bool yemiyedimi(yem oAnki)
        {
            bool sonuc = false;
            if ((x == oAnki.x) && (y == oAnki.y))
            {
                skor++;
                sonuc = true;
            }
            return sonuc;
        }
        public void skoryaz()
        {
            Console.SetCursorPosition(1, 22);
            Console.WriteLine("sokurunuz:{0}",skor);
        }
    }
}