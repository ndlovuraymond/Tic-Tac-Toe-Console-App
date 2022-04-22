using System;

namespace Tic_Tac_Toe_Console_App
{
        class Functions
        {
            public static void game()
            {
                string A = " ";
                string B = " ";
                string C = " ";
                string D = " ";
                string E = " ";
                string F = " ";
                string G = " ";
                string H = " ";
                string I = " ";
                int J = 1;
                string choice = "";
                string move = " ";
                string[] board = { A, B, C, D, E, F, G, H, I };

                Console.WriteLine("Welcome To Tic Tac Toe!");
                Console.WriteLine($"   |   |   \n" + "---+---+--- \n" + $"   |   |   \n" +
                        "---+---+--- \n" + $"   |   |   ");
                do
                {
                    if (J % 2 == 0)
                        move = "O";
                    else
                        move = "X";

                    Console.Write(move + "'s move > ");
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1": if (board[0] == " ") { board[0] = move; } else continue; break;
                        case "2": if (board[1] == " ") { board[1] = move; } else continue; break;
                        case "3": if (board[2] == " ") { board[2] = move; } else continue; break;
                        case "4": if (board[3] == " ") { board[3] = move; } else continue; break;
                        case "5": if (board[4] == " ") { board[4] = move; } else continue; break;
                        case "6": if (board[5] == " ") { board[5] = move; } else continue; break;
                        case "7": if (board[6] == " ") { board[6] = move; } else continue; break;
                        case "8": if (board[7] == " ") { board[7] = move; } else continue; break;
                        case "9": if (board[8] == " ") { board[8] = move; } else continue; break;
                        default: Console.WriteLine("Illegal move!Try Again!"); continue;
                    }

                    Console.WriteLine(board[0] + "  |" + board[1] + "  |" + board[2] + "\n---" + "+" + "---" + "+"
                        + "---" + "\n" + board[3] + "  |" + board[4] + "  |" + board[5] + "\n---" + "+" + "---" + "+"
                        + "---" + "\n" + board[6] + "  |" + board[7] + "  |" + board[8]); J++;
                    if (board[0] == board[1] && board[1] == board[2] && board[0] != " " ||
                        board[3] == board[4] && board[4] == board[5] && board[5] != " " ||
                        board[6] == board[7] && board[7] == board[8] && board[8] != " " ||
                        board[0] == board[3] && board[3] == board[6] && board[6] != " " ||
                        board[1] == board[4] && board[4] == board[7] && board[7] != " " ||
                        board[2] == board[5] && board[5] == board[8] && board[8] != " " ||
                        board[0] == board[4] && board[4] == board[8] && board[4] != " " ||
                        board[6] == board[4] && board[4] == board[2] && board[2] != " ")
                    {
                        Console.WriteLine(move + " won game!"); break;
                    }
                    if (board[0] != " " && board[1] != " " && board[2] != " " && board[3] != " " && board[4] != " "
                        && board[5] != " " && board[6] != " " && board[7] != " " && board[8] != " ")
                    { Console.WriteLine("Tie!"); break; }

                } while (J < 10);
                do
                {
                    Console.Write("Press any key to return to the main menu.");
                    Console.ReadKey();
                    Console.Clear();
                } while (J == 9);
            }
            class Program
            {
                static void Main(string[] args)
                {
                    bool TicTac = true;
                    string quitchoice = " ";
                    string Menu = " ";
                    do
                    {
                        Console.WriteLine("1. New game \n" + "2. About the Author \n" + "3. Exit");
                        Console.Write("> ");
                        Menu = Console.ReadLine();
                        switch (Menu)
                        {
                            case "1":
                                Functions.game();
                                break;
                            case "2":
                                Console.Write("Raymond Ndlovu is a 21 year old Computer Science Student at WSB Poznan. \n"
                                  + "(Press any key to return to Menu)");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case "3":
                                Console.WriteLine("Are you sure you want to quit? [y/n]");
                                Console.Write(">  ");
                                quitchoice = Console.ReadLine();
                                if (quitchoice == "y")
                                    return;
                                if (quitchoice == "Y")
                                    return;
                                Console.Clear();
                                break;
                        }
                    } while (TicTac = true);
                }
            }
        }
    }



