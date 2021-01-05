using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.IO;

namespace euler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loads the text file into array so the numbers can be easily found
            String input = File.ReadAllText(@"C:\Users\jozef\source\repos\euler\euler\array.txt");
            int i = 0, j = 0;
            int[,] grid = new int[20, 20];
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    grid[i, j] = int.Parse(col.Trim());
                    j++;
                }
                i++;
            }
            int max = 1;
            int prod = 1;
            //We iterate through nearly every place in the grid and check the products of their east, south, south-east and north-east numbers
            for (i = 0; i < 20; i++){
                for (j = 0; j < 20; j++)
                {
                    //Check east
                    if (i < 17)
                    {
                        //We find the product of the 4 numbers and change max if it is greater then max
                        prod = grid[i, j] * grid[i + 1, j] * grid[i + 2, j] * grid[i + 3, j];
                        max = Math.Max(max, prod);
                    }
                    //Check south
                    if (j < 17)
                    {
                        prod = grid[i, j] * grid[i, j + 1] * grid[i, j + 2] * grid[i, j + 3];
                        max = Math.Max(max, prod);
                    }
                    //Check south-east
                    if (i < 17 & j <17)
                    {
                        prod = grid[i, j] * grid[i + 1, j + 1] * grid[i + 2, j + 2] * grid[i + 3, j + 3];
                        max = Math.Max(max, prod);
                    }
                    //Check north-east
                    if (i > 2 & j < 17)
                    {
                        prod = grid[i, j] * grid[i - 1, j + 1] * grid[i - 2, j + 2] * grid[i - 3, j + 3];
                        max = Math.Max(max, prod);
                    }
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
