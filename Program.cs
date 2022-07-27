using System;

namespace ForInRowGame

    internal class Program
    {
        static void Main(string[] args)
        {




            {

                string player1 = "X", player2 = "O", player1Name, player2Name;

                int column, row;

                string[,] table = new string[16, 16];

                Console.WriteLine("Welcome to the 4 in the row Game Type the name of the players and enjoy!!");

                Console.WriteLine("Type a name of the player 1");

                player1Name = Console.ReadLine();

                Console.WriteLine("Type a name of the player 2");

                player2Name = Console.ReadLine();



                
                
                while (true)
                {

                    Console.Clear();

                    Board(table);

                    row = 16;

                    Console.WriteLine(player1Name + " Choose a column");

                    column = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(player1Name + " input a " + player1 + " in a column " + column);

                    
                    Console.WriteLine(player2Name + " Choose a column");

                    column = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(player1Name + " input a " + player2 + " in a column " + column);

                    


                    if (table[row, column] == " " && table[row,column] == player1)
                    {
                        table[row, column] = player1;
                    }

                }

                static void Board(string[,] table)
                {
                    Console.WriteLine("  |01 ||02 ||03 ||04 ||05 ||06 ||07 ||08 ||09 ||10 ||11 ||12 ||13 ||14 ||15 ||16 |");
                    for (int i = 1; i < table.GetLength(0) + 1; i++)
                    {
                        if (i < 10)
                        {
                            Console.Write(i + " ");
                        }
                        else
                        {
                            Console.Write(i);
                        }


                        for (int j = 0; j < table.GetLength(1); j++)

                        {

                            Console.Write("|___|");

                        }


                        Console.WriteLine();


                        //    for (int i = 0; i <= table1.GetLength(0); i++)
                        //    {


                        //        table1[i, column] == " ";
                        //}


                    }
                }














            }


        }
    }
}
