using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var input = "2 6 b 1 4 7 c 8 3 5 9 e d 0 a f 9 7 5 3 a 1 6 f 8 0 d c 4 e b 2 f e c d 9 3 5 0 a 2 b 4 6 7 1 8 a 4 8 0 b d 2 e 7 1 6 f 9 5 c 3 6 f 3 b c 5 d a 1 7 e 9 2 8 4 0 7 d 1 8 0 2 f 6 c 4 5 a e b 3 9 5 9 e 4 7 8 3 b 0 6 f 2 a 1 d c 0 c 2 a 1 4 e 9 d b 8 3 7 f 6 5 c 3 4 5 e 6 9 2 f d 7 0 b a 8 1 e 1 0 6 d b 4 3 2 8 a 5 c 9 f 7 b 2 f 7 8 c a 1 e 9 3 6 5 4 0 d 8 a d 9 f 0 7 5 b c 4 1 3 2 e 6 1 5 6 c 3 e 0 7 4 f 2 b 8 d 9 a 4 8 a 2 5 f b c 9 3 1 d 0 6 7 e 3 b 7 e 6 9 1 d 5 a 0 8 f c 2 4 d 0 9 f 2 a 8 4 6 e c 7 1 3 5 b";
            var input1 = "1 1 1 1 2 2 2 2 3 3 3 3 4 4 4 4 1 1 1 1 2 2 2 2 3 3 3 3 4 4 4 4 1 1 1 1 2 2 2 2 3 3 3 3 4 4 4 4 1 1 1 1 2 2 2 2 3 3 3 3 4 4 4 4 5 5 5 5 6 6 6 6 7 7 7 7 8 8 8 8 5 5 5 5 6 6 6 6 7 7 7 7 8 8 8 8 5 5 5 5 6 6 6 6 7 7 7 7 8 8 8 8 5 5 5 5 6 6 6 6 7 7 7 7 8 8 8 8 9 9 9 9 0 0 0 0 a a a a b b b b 9 9 9 9 0 0 0 0 a a a a b b b b 9 9 9 9 0 0 0 0 a a a a b b b b 9 9 9 9 0 0 0 0 a a a a b b b b c c c c d d d d e e e e f f f f c c c c d d d d e e e e f f f f c c c c d d d d e e e e f f f f c c c c d d d d e e e e f f f f";
            var newInput = input1.Replace(" ","");
            getRows(newInput);
            getColumns(newInput);
            getGrids(newInput);
            Console.ReadLine();
        }

        private static void getRows(string input)
        {
            List<string> rows = new List<string>();

            for (int currentRow = 0; currentRow < 16; currentRow++)
            {
                string row = "";
                
                for (int i = 0; i < 16; i++)
                {
                    row += input[i + (currentRow * 16)];
                }

                rows.Add(row);
            }

            PrintOutput("Rows:", rows);
        }

        private static void getColumns(string input)
        {
            List<string> columns = new List<string>();

            for(int currentColumn = 0; currentColumn < 16; currentColumn++)
            {
                string column = "";
                
                for (int i = 0; i < 16; i++)
                {
                    column += input[currentColumn + (i * 16)];
                }

                columns.Add(column);
            }

            PrintOutput("Columns:", columns);
        }

        private static void getGrids(string input)
        {
            List<string> grids = new List<string>();
            int startOfGrid; 
            const int Reset = 0;
            string currentGrid = String.Empty;
            

            for (int column = 0; column < 4; column++)
            {
                startOfGrid = column * 4;

                for (int row = 0; row < 16; row++)
                {
                    for (int val = 0; val < 4; val++)
                    {
                        currentGrid += input[val + startOfGrid];
                    }

                    if (startOfGrid == ((64 * ((row / 4) + 1)) - 16) + (column * 4))
                        //startOfGrid == (48 + (column * 4)) ||
                        //startOfGrid == (112 + (column * 4)) ||
                        //startOfGrid == (176 + (column * 4)) ||
                        //startOfGrid == (240 + (column * 4)))
                    {
                        grids.Add(currentGrid);
                        currentGrid = String.Empty;
                    }

                    startOfGrid += 16;
                }

                startOfGrid = Reset;
            }

            PrintOutput("Grids:", grids);
        }
        
        private static void PrintOutput(string title, List<string> output)
        {
            Console.WriteLine(title);
            foreach (var line in output)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();
        }

    }
}

 #region AssHat_Attempts
            //int gridIterator = 0;
            //int shift = 0;
            //string gridValue = string.Empty;

            //for (int grid = 0; grid < 4; grid++ )
            //{
            //    gridValue = string.Empty;
                
            //    for(int row = 0; row < 4; row++)
            //    {
            //        for (int i = 0; i < 4; i++)
            //        {
            //            gridValue += input[shift + i];
            //        }

            //        if(grid == 3)
            //        {
            //            Console.WriteLine();
            //        }
            //        else
            //        {
            //            shift += 16;
            //        }
                    
            //    }
                
                
            //}
        //}


		            //string current = String.Empty;
            //int first = 0;
            //int moveToNextRow = 0;
            //int moveToNextGrid = 0;
            //int grid = 0;

            //while(first < 240)
            //{
            //    //get each row
            //    for(int i = 0; i < 4; i++)
            //    {
            //        current += input[first + i];
            //    }

            //    moveToNextRow++;
            //    if(moveToNextRow == 4)
            //    {
            //        moveToNextRow = 0;
            //        moveToNextGrid++;
            //        grids.Add(current);
            //        current = String.Empty;
            //        grid++;

            //        if(moveToNextGrid % 4 == 0)
            //        {
            //            first = 4 * moveToNextRow * grid;
            //        }
            //        else
            //        {
            //            first = 4 * grid;
            //        }
            //    }
            //    else
            //    {
            //        first += 16;
            //    }


            //} 


        



        //int first = 0;
        //int col, row = 0;
        //string current = String.Empty;
        //int totalGrids = 0;

        //while(totalGrids <= 16)
        //{
        //    if (totalGrids < 4)
        //        col = 0;
        //    else if (totalGrids < 8)
        //        col = 4;
        //    else if (totalGrids < 12)
        //        col = 8;
        //    else col = 12;

        //    row = 0 + (totalGrids * 4);

        //    while (row < 4)
        //    {
        //        while (col < 4)
        //        {
        //            current += input[first + col];
        //            col++;
        //        }

        //        if (first < 240)
        //        {
        //            first += 16;
        //        }

        //        row++;
        //    }
        //    grids.Add(current);
        //    totalGrids++;  
#endregion
    


