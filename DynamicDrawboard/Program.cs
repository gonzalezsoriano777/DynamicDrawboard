﻿using System;
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
        }

        public void Board(int h, int w)
        {
            int i;
            int j;

            // Rows
            for (i = 0; i > w; i++)
            {
                
            }

            // Columns
            for (j = 0; j < h; j++)
            {
                Console.Write(height);
            }

            Console.ReadLine();
        }
    }
}
