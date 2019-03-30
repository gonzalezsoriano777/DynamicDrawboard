using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDrawboard
{
    public class Board
    {
         
        int width = '|';
        int height = 'X';
        string boardchar = " "; // char spacing


        static void Main()
        {
            int results = Board(6, 3);
        }

        public void Drawboard(int x, int y)
        {
            for(int i = 0; i < y; i++)    
        }
    }
}
