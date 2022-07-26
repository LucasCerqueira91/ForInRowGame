using System;

namespace ForInRowGame
{
    public class Program
    {
        static void Main(string[] args)


        {

            string player1 = "X", player2 = "O";

            int column, row;

            string[,] table = new string[16,16];

            Console.WriteLine("Welcome to the 4 in the row Game Type the name of the players and enjoy!!");

            Console.WriteLine("Type a name of the player 1");

            player1 = Console.ReadLine();

            Console.WriteLine("Type a name of the player 2");

            player2 = Console.ReadLine();



            while (true)
            {

                Console.Clear();

                Board(table);

                row = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine(player1 + " Choose a column");

                column = Convert.ToInt32(Console.ReadLine());
                                
                player1 = table[row,column];
                
                Console.WriteLine(player2 + " Choose a column");

                column = Convert.ToInt32(Console.ReadLine());
                
                player2 = table[row,column];

                

                

            }



            static void Board(string[,] table1)

            {
                Console.WriteLine("  |01 ||02 ||03 ||04 ||05 ||06 ||07 ||08 ||09 ||10 ||11 ||12 ||13 ||14 ||15 ||16 |");
                for (int i = 1; i < table1.GetLength(0) + 1; i++)
                {
                    if (i < 10)
                    {
                        Console.Write(i + " ");
                    }
                    else
                    {
                        Console.Write(i);
                    }


                    for (int j = 0; j < table1.GetLength(1); j++)

                    {

                        Console.Write("|___|");

                    }


                    Console.WriteLine();


                }
            }






           







        }


    }
}
