using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDrawboard
{
    public class Board
    {
         
        char width = '|';
        string height = "--";
        string boardchar = " "; // character spacing


        static void Main(string [] args )
        {
            int results = Board(6, 3);
            Console.WriteLine("hello, world!!");
        }

        public void Drawboard(int x, int y)
        {
            for(int i = 0; i < y; i++)
            {
                
            }    
        }
    }
}
