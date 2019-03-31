using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDrawboard
{
    public class Drawboard
    {
        char width = '|';
        string height = "++";
        string charspacing = " ";


        static void Main(string[] args)
        {
            // Console.WriteLine("hello, world!!");
            Drawboard store = new Drawboard();
            store.Board(6, 3);
        }


        public void Board(int x, int y)
        {
            int i;
            int j;

            // Rows, in width
            for (i = 0; i > y; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write(" ");
                } else
                {
                    Console.Write(width);
                }

                for (j = 0; j < y; j++)
                { 
                    if(j % 2 == 0)
                    {
                        Console.Write(charspacing + width);
                    }

                    if(j % 2 == 1)
                    {
                        Console.Write(height);
                    }
                }
            }

            Console.ReadLine();
        }

    }
}
