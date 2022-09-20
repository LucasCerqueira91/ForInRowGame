using System;
using System.Linq;

namespace ForInRowGame
{

    internal class Program
    {
        static void Main(string[] args)
        {




            {
                string player1, player2, player1Name, player2Name, turnPlayer;
                int column, row = 16, moves = 0;
                // meter um for com espaços vazios no array
                

                //int columns = table.GetLength(1);
                //int rows = table.GetLength(0);
                //var temp = Enumerable.Range(0, rows)
                //    .Select(i => Enumerable.Range(0, columns).Select(j => table[i, j]).ToList())
                //    .Where(row => !row.All(string.IsNullOrEmpty))
                //    .ToList();

                //string[,] result = new string[temp.Count, columns];
                //rows = temp.Count;

                //for (int r = 0; r < rows; r++)
                //{
                //    var row1 = temp[r];
                //    for (var c = 0; c < row1.Count; c++)
                //    {
                //        result[r, c] = row1[c];
                //    }
                //}
                

                Console.WriteLine("Welcome to the 4 in the row Game Type the name of the players and enjoy!!");
                Console.WriteLine("Type a name of the player 1");
                player1Name = Console.ReadLine();
                player1 = "X";
                Console.WriteLine("Type a name of the player 2");
                player2Name = Console.ReadLine();
                player2 = "O";
                string[,] table = new string[17, 17];


                for (int r = 0; r < table.GetLength(0); r++)
                {
                    for (int c = 0; c < table.GetLength(1); c++)
                    {
                        Console.WriteLine(table[r, c] = " ");
                    }
                }

                while (true)
                {

                    Console.Clear();
                    Board(table);
                    turnPlayer = player1;
                    Console.WriteLine(player1Name + " Choose a column");
                    column = Convert.ToInt32(Console.ReadLine());
                    if (table[row, column] != "X" && table[row, column] != "O")
                    {
                        table[row, column] = turnPlayer;
                        Console.WriteLine(player1Name + " input a " + player1 + " in a column " + column);
                    }
                    else
                    {
                        Console.WriteLine(player1Name + " This column is full please Choose a column empty");
                        column = Convert.ToInt32(Console.ReadLine());
                        table[row, column] = turnPlayer;
                        Console.WriteLine(player1Name + " input a " + player1 + " in a column " + column);
                    }


                    Console.Clear();
                    Board(table);
                    turnPlayer = player2;
                    Console.WriteLine(player2Name + " Choose a column");
                    column = Convert.ToInt32(Console.ReadLine());
                    if (table[row, column] != "X" && table[row, column] != "O")
                    {
                        table[row, column] = turnPlayer;
                        Console.WriteLine(player2Name + " input a " + player2 + " in a column " + column);
                    }
                    else
                    {
                        Console.WriteLine(player2Name + " This column is full please Choose a column empty");
                        column = Convert.ToInt32(Console.ReadLine());
                        table[row, column] = turnPlayer;
                        Console.WriteLine(player2Name + " input a " + player2 + " in a column " + column);
                    }
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


                for (int i = 1; i < table.GetLength(0); i++)
                {
                    if (i <= 16)
                    {
                        Console.Write("  ");
                    }


                    for (int j = 1; j < table.GetLength(1); j++)

                    {


                        Console.Write("|_" + table[i, j] + "|");


                        //https://stackoverflow.com/questions/60812682/c-sharp-how-to-replace-the-variables-inside-strings

                        //string finalLine = "__";

                        //for (int i = 0; i < 18; i++)
                        //{
                        //    for (int j = 0; j < 18; j++)
                        //    {
                        //        if (table[i, j] == " ")
                        //            table[i, j] = turnPlayer;
                        //    }
                        //}

                        //string result = finalLine.Replace("{ table[i, j]}", finalLine);
                        //result = finalLine;
                        //if (result == table[i, j])
                        //{
                        //    Console.Write("|" + result + "|");
                        //}
                        //else
                        //{
                        //    Console.Write("|" + finalLine + "|");
                        //}


                        //if (table[i,j] != finalLine)
                        //{
                        //   var chenge = new StringBuilder(finalLine);
                        //    chenge[0] = table[i, j];
                        //    finalLine = chenge.ToString();

                        //}
                        //var theString = "ABCDEF";
                        //var sb = new StringBuilder(theString);
                        //sb[2] = "r" //replace letter at index 2 with "r"
                        //theString = sb.ToString(); //theString: "ABrDEF"

                        ////Console.Write("| " + finalLine);
                        ////Console.Write(table[i, j] + finalLine.Replace("_", table[i, j]));

                        //////string source = "Many mountains are behind many clouds today.";
                        ////// Remove a substring from the middle of the string.
                        //////Remove text console c#
                    }

                    Console.WriteLine();


                }
            }



        }


    }
}
