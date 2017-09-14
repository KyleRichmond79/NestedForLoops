using System;
namespace NestedForLoops
{
    class Program
    {
        //this is the method that NestedForLoops will be executed
        //static void Main is taking 2 strings and a 2D array which is assigned
        //to a new string with 5 rows and columns to create set up the nested array
        static void Main(string[] args)
        {
            string c = "catnip ";
            string m = "mint   ";
            string[,] JosiesGarden = new string[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i % 2 == 0)
                    {
                        JosiesGarden[i, j] = c;
                        if ((j > 0) && (JosiesGarden[i, j - 1] == c))
                        {
                            JosiesGarden[i, j] = m;
                        }
                    }
                    else
                    {
                        JosiesGarden[i, j] = m;
                        if ((j > 0) && (JosiesGarden[i, j - 1] == m))
                        {
                            JosiesGarden[i, j] = c;
                        }
                    }
                    //below JosiesGarden is being written to the console as the [5,5] table 
                    Console.Write(JosiesGarden[i, j]);
                }
                //below the empty string WriteLine is creating spaces for ease of reading
                Console.WriteLine("");
            }
            Console.Read();
        }
    }
}
