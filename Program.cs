using System;

namespace ForInRowGame
{

    internal class Program
    {
        static void Main(string[] args)
        {




            {
                string player1 = "X", player2 = "O", player1Name, player2Name, turnPlayer;
                int column, row = 15, moves = 0;
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
                    turnPlayer = player1;
                    Console.WriteLine(player1Name + " Choose a column");
                    column = Convert.ToInt32(Console.ReadLine());
                    table[row, column] = turnPlayer;
                    Console.WriteLine(player1Name + " input a " + player1 + " in a column " + column);
                    Console.Clear();
                    Board(table);
                    turnPlayer = player2;
                    Console.WriteLine(player2Name + " Choose a column");
                    column = Convert.ToInt32(Console.ReadLine());
                    table[row, column] = turnPlayer;
                    Console.WriteLine(player2Name + " input a " + player2 + " in a column " + column);
                    Console.Clear();
                    Board(table);

                    if (VictoryChecker(table))
                    {
                        Console.WriteLine("The player " + turnPlayer + " is the Winner!!");
                    }
                    moves = moves + 1;

                    if (moves == 256)
                    {
                        Console.WriteLine("Draw");

                        break;
                    }
                }

                static bool VictoryChecker(string[,] table)

                {

                    for (int i = 0; i < table.GetLength(0); i++)
                    {
                        if (table[i, 0] == table[i, 1] && table[i, 1] == table[i, 2] && table[i, 2] == table[i, 2] && table[i, 1] != " ")

                        {
                            return true;
                        }
                    }

                    for (int i = 0; i < table.GetLength(1); i++)
                    {
                        if (table[i, 1] == table[i, 2] && table[i, 2] == table[i, 3] && table[i, 3] == table[i, 4] && table[i, 1] != " ")
                        {
                            return true;
                        }
                    }

                    for (int i = 0; i < table.GetLength(1); i++)
                    {
                        if (table[1, 1] == table[2, 2] && table[2, 2] == table[3, 3] && table[3, 3] == table[4, 4] && table[1, i] != " ")
                        {
                            return true;
                        }

                    }
                    for (int i = 0; i < table.GetLength(1); i++)
                        if (table[1, 2] == table[2, 2] && table[1, 1] == table[2, 0] && table[1, i] != " ")
                        {
                            return true;
                        }
                    return false;
                }




            }

            static void Board(string[,] table)


            {

                Console.WriteLine("  |01||02||03||04||05||06||07||08||09||10||11||12||13||14||15||16|");


                for (int i = 0; i < table.GetLength(0); i++)
                {
                    if (i <= 16)
                    {
                        Console.Write("  ");
                    }


                    for (int j = 0; j < table.GetLength(1); j++)

                    {
                        string finalLine = "_|";

                        int removeLine = 0;
                        Console.Write("|_" + table[i, j] +  finalLine);
                        finalLine.Remove(removeLine);



                    }


                    Console.WriteLine();





                }
            }













        }


    }
}
