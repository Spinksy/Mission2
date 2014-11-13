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
            var input = "2 6 b 1 4 7 c 8 3 5 9 e d 0 a f 9 7 5 3 a 1 6 f 8 0 d c 4 e b 2 f e c d 9 3 5 0 a 2 b 4 6 7 1 8 a 4 8 0 b d 2 e 7 1 6 f 9 5 c 3 6 f 3 b c 5 d a 1 7 e 9 2 8 4 0 7 d 1 8 0 2 f 6 c 4 5 a e b 3 9 5 9 e 4 7 8 3 b 0 6 f 2 a 1 d c 0 c 2 a 1 4 e 9 d b 8 3 7 f 6 5 c 3 4 5 e 6 9 2 f d 7 0 b a 8 1 e 1 0 6 d b 4 3 2 8 a 5 c 9 f 7 b 2 f 7 8 c a 1 e 9 3 6 5 4 0 d 8 a d 9 f 0 7 5 b c 4 1 3 2 e 6 1 5 6 c 3 e 0 7 4 f 2 b 8 d 9 a 4 8 a 2 5 f b c 9 3 1 d 0 6 7 e 3 b 7 e 6 9 1 d 5 a 0 8 f c 2 4 d 0 9 f 2 a 8 4 6 e c 7 1 3 5 b";
            getGrids(input.Replace(" ",""));
        }

        //public static void getColumns(string input) 
        //{
        //    List<string> columns = new List<string>();

        //    for (int col = 1; col <= 16; col++ )
        //    {
        //        string col = "";
        //        for (int i = 0; i < 256; i += 16)
        //        {
        //            col += input[i];
        //        }

        //        columns.Add(col);
        //    }
        //}

        public static void getGrids(string input)
        {
            List<string> grids = new List<string>();
            int start = 0; 

            //Fill 16 grids
            for(int grid = 0; grid < 16; grid++)
            {
                string current = "";

                //With 16 numbers
                for (int dig = 1; dig <= 16; dig++)
                {
                    for (int i = 0; i < 4; i++ )
                    {
                        current += Convert.ToInt32(input[start + i]);
                    }
                    
                    start += 12;
                }

                grids.Add(current);

                Console.ReadLine();
            }
        }


    }
}
