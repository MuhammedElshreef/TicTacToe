using System;

namespace TicTacToe
{
    class Program
    {
        static bool winnerPLayerBoolean;
        static string winnerPlayer;
        static bool tiedGameBoolean = false;
        static bool turnCheck = false;
        static bool gameOverCheck = false;
        static string[,] matrix = new string[,]
        {
             {"1","2","3"},
             {"4","5","6"},
             {"7","8","9"}
        };
        static void Main(string[] args)
        {
            SetField();
        }
        public static void SetField()
        {
            while (gameOverCheck == false)
            {
                GameOver(false);
                if (gameOverCheck == true)
                    CheckTheWinner();
                else if (tiedGameBoolean == true)
                    TiedGame();
                else
                {
                    Console.WriteLine("Player 1 have the X mark");
                    Console.WriteLine("Player 2 have the o mark");
                    Console.WriteLine(string.Empty);
                    Console.WriteLine("     |      |     ");
                    Console.WriteLine(" {0}   |  {1}   | {2}", matrix[0, 0], matrix[0, 1], matrix[0, 2]);
                    Console.WriteLine("_____|______|_____");
                    Console.WriteLine("     |      |     ");
                    Console.WriteLine(" {0}   |  {1}   | {2}", matrix[1, 0], matrix[1, 1], matrix[1, 2]);
                    Console.WriteLine("_____|______|_____");
                    Console.WriteLine("     |      |     ");
                    Console.WriteLine(" {0}   |  {1}   | {2}", matrix[2, 0], matrix[2, 1], matrix[2, 2]);
                    Console.WriteLine("     |      |     ");
                    if (turnCheck == false)
                        PlayerOne();
                    else
                        PlayerTwo();
                }

            }

        }
        public static void PlayerOne(bool playerOneCheck = false)
        {

            Console.Write("Player 1 : Please select number from 1 to 9 to put the mark : ");
            string mark = Console.ReadLine();
            int markNum;
            if (int.TryParse(mark, out markNum))
            {
                 if (markNum > 9 || markNum < 1)
                {
                    Console.WriteLine("Faild, Please enter number between 1 and 9");
                    PlayerOne();

                }
                switch (markNum)
                {
                    case 1:
                        if (matrix[0, 0].Equals("x") || matrix[0, 0].Equals("o"))
                        {
                            Console.WriteLine("It's already taken ");
                            PlayerOne();
                        }
                        else
                        {
                            matrix[0, 0] = "x";
                            playerOneCheck = true;
                            turnCheck = playerOneCheck;
                            SetField();
                            if (gameOverCheck == true)
                            {
                                if (tiedGameBoolean == true)
                                    TiedGame();
                                CheckTheWinner();
                            }
                            else
                            {
                                PlayerTwo();
                            }
                        }
                        break;
                    case 2:
                        if (matrix[0, 1].Equals("x") || matrix[0, 1].Equals("o"))
                        {
                            Console.WriteLine("It's already taken");
                            PlayerOne();
                        }
                        else
                        {
                            matrix[0, 1] = "x";
                            playerOneCheck = true;
                            turnCheck = playerOneCheck;
                            SetField();
                            if (gameOverCheck == true)
                            {
                                if (tiedGameBoolean == true)
                                    TiedGame();
                                CheckTheWinner();
                            }
                            else
                            {
                                PlayerTwo();
                            }
                        }
                        break;
                    case 3:
                        if (matrix[0, 2].Equals("x") || matrix[0, 2].Equals("o"))
                        {
                            Console.WriteLine("It's already taken ");
                            PlayerOne();
                        }
                        else
                        {
                            matrix[0, 2] = "x";
                            playerOneCheck = true;
                            turnCheck = playerOneCheck;
                            SetField();
                            if (gameOverCheck == true)
                            {
                                if (tiedGameBoolean == true)
                                    TiedGame();
                                CheckTheWinner();
                            }
                            else
                            {
                                PlayerTwo();
                            }
                        }
                        break;
                    case 4:
                        if (matrix[1, 0].Equals("x") || matrix[1, 0].Equals("o"))
                        {
                            Console.WriteLine("It's already taken ");
                            PlayerOne();
                        }
                        else
                        {
                            matrix[1, 0] = "x";
                            playerOneCheck = true;
                            turnCheck = playerOneCheck;
                            SetField();
                            if (gameOverCheck == true)
                            {
                                if (tiedGameBoolean == true)
                                    TiedGame();
                                CheckTheWinner();
                            }
                            else
                            {
                                PlayerTwo();
                            }
                        }
                        break;
                    case 5:
                        if (matrix[1, 1].Equals("x") || matrix[1, 1].Equals("o"))
                        {
                            Console.WriteLine("It's already taken ");
                            PlayerOne();
                        }
                        else
                        {
                            matrix[1, 1] = "x";
                            playerOneCheck = true;
                            turnCheck = playerOneCheck;
                            SetField();
                            if (gameOverCheck == true)
                            {
                                if (tiedGameBoolean == true)
                                    TiedGame();
                                CheckTheWinner();
                            }
                            else
                            {
                                PlayerTwo();
                            }
                        }
                        break;
                    case 6:
                        if (matrix[1, 2].Equals("x") || matrix[1, 2].Equals("o"))
                        {
                            Console.WriteLine("It's already taken ");
                            PlayerOne();
                        }
                        else
                        {
                            matrix[1, 2] = "x";
                            playerOneCheck = true;
                            turnCheck = playerOneCheck;
                            SetField();
                            if (gameOverCheck == true)
                            {
                                if (tiedGameBoolean == true)
                                    TiedGame();
                                CheckTheWinner();
                            }
                            else
                            {
                                PlayerTwo();
                            }
                        }
                        break;
                    case 7:
                        if (matrix[2, 0].Equals("x") || matrix[2, 0].Equals("o"))
                        {
                            Console.WriteLine("It's already taken ");
                            PlayerOne();
                        }
                        else
                        {
                            matrix[2, 0] = "x";
                            playerOneCheck = true;
                            turnCheck = playerOneCheck;
                            SetField();
                            if (gameOverCheck == true)
                            {
                                if (tiedGameBoolean == true)
                                    TiedGame();
                                CheckTheWinner();
                            }
                            else
                            {
                                PlayerTwo();
                            }
                        }
                        break;
                    case 8:
                        if (matrix[2, 1].Equals("x") || matrix[2, 1].Equals("o"))
                        {
                            Console.WriteLine("It's already taken ");
                            PlayerOne();
                        }
                        else
                        {
                            matrix[2, 1] = "x";
                            playerOneCheck = true;
                            turnCheck = playerOneCheck;
                            SetField();
                            if (gameOverCheck == true)
                            {
                                if (tiedGameBoolean == true)
                                    TiedGame();
                                CheckTheWinner();
                            }
                            else
                            {
                                PlayerTwo();
                            }
                        }
                        break;
                    case 9:
                        if (matrix[2, 2].Equals("x") || matrix[2, 2].Equals("o"))
                        {
                            Console.WriteLine("It's already taken ");
                            PlayerOne();
                        }
                        else
                        {
                            matrix[2, 2] = "x";
                            playerOneCheck = true;
                            turnCheck = playerOneCheck;
                            SetField();
                            if (gameOverCheck == true)
                            {
                                if (tiedGameBoolean == true)
                                    TiedGame();
                                CheckTheWinner();
                            }
                            else
                            {
                                PlayerTwo();
                            }

                        }
                        break;
                }

            }
            else
            {
                Console.WriteLine("Incorrect value, Please enter a number");
                PlayerOne();
            }


        }
        public static void PlayerTwo(bool playerTwoCheck = true)
        {

            Console.Write("Player 2 : Please select number from 1 to 9 to put the mark : ");
            string mark = Console.ReadLine();
            int markNum;
            if (int.TryParse(mark, out markNum))
            {
                if (markNum > 9 || markNum < 1)
                {
                    Console.WriteLine("Faild, Please enter number between 1 and 9");
                    PlayerTwo();

                }
                switch (markNum)
                {
                    case 1:
                        if (matrix[0, 0].Equals("x") || matrix[0, 0].Equals("o"))
                        {
                            Console.WriteLine("It's already taken ");
                            PlayerTwo();
                        }
                        else
                        {
                            matrix[0, 0] = "o";
                            playerTwoCheck = false;
                            turnCheck = playerTwoCheck;
                            SetField();
                            if (gameOverCheck == true)
                            {
                                if (tiedGameBoolean == true)
                                    TiedGame();
                                CheckTheWinner();
                            }
                            else
                            {
                                PlayerOne();
                            }
                        }
                        break;
                    case 2:
                        if (matrix[0, 1].Equals("x") || matrix[0, 1].Equals("o"))
                        {
                            Console.WriteLine("It's already taken ");
                            PlayerTwo();
                        }
                        else
                        {
                            matrix[0, 1] = "o";
                            playerTwoCheck = false;
                            turnCheck = playerTwoCheck;
                            SetField();
                            if (gameOverCheck == true)
                            {
                                if (tiedGameBoolean == true)
                                    TiedGame();
                                CheckTheWinner();
                            }
                            else
                            {
                                PlayerOne();
                            }
                        }
                        break;
                    case 3:
                        if (matrix[0, 2].Equals("x") || matrix[0, 2].Equals("o"))
                        {
                            Console.WriteLine("It's already taken ");
                            PlayerTwo();
                        }
                        else
                        {
                            matrix[0, 2] = "o";
                            playerTwoCheck = false;
                            turnCheck = playerTwoCheck;
                            SetField();
                            if (gameOverCheck == true)
                            {
                                if (tiedGameBoolean == true)
                                    TiedGame();
                                CheckTheWinner();
                            }
                            else
                            {
                                PlayerOne();
                            }
                        }
                        break;
                    case 4:
                        if (matrix[1, 0].Equals("x") || matrix[1, 0].Equals("o"))
                        {
                            Console.WriteLine("It's already taken ");
                            PlayerTwo();
                        }
                        else
                        {
                            matrix[1, 0] = "o";
                            playerTwoCheck = false;
                            turnCheck = playerTwoCheck;
                            SetField();
                            if (gameOverCheck == true)
                            {
                                if (tiedGameBoolean == true)
                                    TiedGame();
                                CheckTheWinner();
                            }
                            else
                            {
                                PlayerOne();
                            }
                        }
                        break;
                    case 5:
                        if (matrix[1, 1].Equals("x") || matrix[1, 1].Equals("o"))
                        {
                            Console.WriteLine("It's already taken ");
                            PlayerTwo();
                        }
                        else
                        {
                            matrix[1, 1] = "o";
                            playerTwoCheck = false;
                            turnCheck = playerTwoCheck;
                            SetField();
                            if (gameOverCheck == true)
                            {
                                if (tiedGameBoolean == true)
                                    TiedGame();
                                CheckTheWinner();
                            }
                            else
                            {
                                PlayerOne();
                            }
                        }
                        break;
                    case 6:
                        if (matrix[1, 2].Equals("x") || matrix[1, 2].Equals("o"))
                        {
                            Console.WriteLine("It's already taken ");
                            PlayerTwo();
                        }
                        else
                        {
                            matrix[1, 2] = "o";
                            playerTwoCheck = false;
                            turnCheck = playerTwoCheck;
                            SetField();
                            if (gameOverCheck == true)
                            {
                                if (tiedGameBoolean == true)
                                    TiedGame();
                                CheckTheWinner();
                            }
                            else
                            {
                                PlayerOne();
                            }
                        }
                        break;
                    case 7:
                        if (matrix[2, 0].Equals("x") || matrix[2, 0].Equals("o"))
                        {
                            Console.WriteLine("It's already taken ");
                            PlayerTwo();
                        }
                        else
                        {
                            matrix[2, 0] = "o";
                            playerTwoCheck = false;
                            turnCheck = playerTwoCheck;
                            SetField();
                            if (gameOverCheck == true)
                            {
                                if (tiedGameBoolean == true)
                                    TiedGame();
                                CheckTheWinner();
                            }
                            else
                            {
                                PlayerOne();
                            }
                        }
                        break;
                    case 8:
                        if (matrix[2, 1].Equals("x") || matrix[2, 1].Equals("o"))
                        {
                            Console.WriteLine("It's already taken ");
                            PlayerTwo();
                        }
                        else
                        {
                            matrix[2, 1] = "o";
                            playerTwoCheck = false;
                            turnCheck = playerTwoCheck;
                            SetField();
                            if (gameOverCheck == true)
                            {
                                if (tiedGameBoolean == true)
                                    TiedGame();
                                CheckTheWinner();
                            }
                            else
                            {
                                PlayerOne();
                            }
                        }
                        break;
                    case 9:
                        if (matrix[2, 2].Equals("x") || matrix[2, 2].Equals("o"))
                        {
                            Console.WriteLine("It's already taken ");
                            PlayerTwo();
                        }
                        else
                        {
                            matrix[2, 2] = "o";
                            playerTwoCheck = false;
                            turnCheck = playerTwoCheck;
                            SetField();
                            if (gameOverCheck == true)
                            {
                                if (tiedGameBoolean == true)
                                    TiedGame();
                                CheckTheWinner();
                            }
                            else
                            {
                                PlayerOne();
                            }


                        }
                        break;
                }

                playerTwoCheck = false;
                turnCheck = playerTwoCheck;

            }
            else
            {
                Console.WriteLine("Incorrect value, Please enter a number");
                PlayerTwo();
            }
        }

        public static void GameOver(bool gameOverCheckBoolean)
        {
            if (matrix[0, 0] == matrix[0, 1] && matrix[0, 1] == matrix[0, 2])
                gameOverCheckBoolean = true;
            if (matrix[1, 0] == matrix[1, 1] && matrix[1, 1] == matrix[1, 2])
                gameOverCheckBoolean = true;
            if (matrix[2, 0] == matrix[2, 1] && matrix[2, 1] == matrix[2, 2])
                gameOverCheckBoolean = true;
            if (matrix[0, 0] == matrix[1, 0] && matrix[1, 0] == matrix[2, 0])
                gameOverCheckBoolean = true;
            if (matrix[0, 1] == matrix[1, 1] && matrix[1, 1] == matrix[2, 1])
                gameOverCheckBoolean = true;
            if (matrix[0, 2] == matrix[1, 2] && matrix[1, 2] == matrix[2, 2])
                gameOverCheckBoolean = true;
            if (matrix[0, 0] == matrix[1, 1] && matrix[1, 1] == matrix[2, 2])
                gameOverCheckBoolean = true;
            if (matrix[0, 2] == matrix[1, 1] && matrix[1, 1] == matrix[2, 0])
                gameOverCheckBoolean = true;
            gameOverCheck = gameOverCheckBoolean;

            if (!(matrix[0, 0].Equals("1")))
            {
                if (!(matrix[0, 1].Equals("2")))
                {
                    if(!(matrix[0,2].Equals("3")))
                    {
                        if (!(matrix[1,0].Equals("4")))
                        {
                            if (!(matrix[1,1].Equals("5")))
                            {
                                if (!(matrix[1,2].Equals("6")))
                                {
                                    if (!(matrix[2,0].Equals("7")))
                                    {
                                        if (!(matrix[2,1].Equals("8")))
                                        {
                                            if (!(matrix[2, 2].Equals("9")))
                                            {
                                                if (matrix[0, 0] == matrix[0, 1] && matrix[0, 1] == matrix[0, 2])
                                                    gameOverCheckBoolean = true;
                                                if (matrix[1, 0] == matrix[1, 1] && matrix[1, 1] == matrix[1, 2])
                                                    gameOverCheckBoolean = true;
                                                if (matrix[2, 0] == matrix[2, 1] && matrix[2, 1] == matrix[2, 2])
                                                    gameOverCheckBoolean = true;
                                                if (matrix[0, 0] == matrix[1, 0] && matrix[1, 0] == matrix[2, 0])
                                                    gameOverCheckBoolean = true;
                                                if (matrix[0, 1] == matrix[1, 1] && matrix[1, 1] == matrix[2, 1])
                                                    gameOverCheckBoolean = true;
                                                if (matrix[0, 2] == matrix[1, 2] && matrix[1, 2] == matrix[2, 2])
                                                    gameOverCheckBoolean = true;
                                                if (matrix[0, 0] == matrix[1, 1] && matrix[1, 1] == matrix[2, 2])
                                                    gameOverCheckBoolean = true;
                                                if (matrix[0, 2] == matrix[1, 1] && matrix[1, 1] == matrix[2, 0])
                                                    gameOverCheckBoolean = true;
                                                gameOverCheck = gameOverCheckBoolean;
                                                if(gameOverCheckBoolean == false)
                                                {
                                                    tiedGameBoolean = true;
                                                    TiedGame();
                                                }

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                
            }

            //if (matrix[0, 0] == "x" && matrix[0, 0] == matrix[0, 1] && matrix[0, 1] != matrix[0, 2] || matrix[0, 0] == "x" && matrix[0, 0] != matrix[0, 1] && matrix[0, 1] == matrix[0, 2] || matrix[0, 0] == "x" && matrix[0, 1] == matrix[0, 0] && matrix[0, 0] != matrix[0, 2])
            //{
            //    tiedGameBoolean = true;
            //    TiedGame();
            //}
            //else
            //{
            //    tiedGameBoolean = false;
            //}

            //if (matrix[1, 0] == "x" && matrix[1, 0] == matrix[1, 1] && matrix[1, 1] != matrix[1, 2] || matrix[0, 0] == "x" && matrix[1,0] != matrix[1, 1] && matrix[1, 1] == matrix[1, 2] || matrix[0, 0] == "x" && matrix[1, 1] == matrix[1, 0] && matrix[1, 0] != matrix[1, 2] )
            //{
            //    tiedGameBoolean = true;
            //    TiedGame();
            //}
            //else
            //{
            //    tiedGameBoolean = false;
            //}
            //if (matrix[2, 0] == "x" && matrix[2, 0] == matrix[2, 1] && matrix[2, 1] != matrix[2, 2] || matrix[0, 0] == "x" && matrix[2, 0] != matrix[2, 1] && matrix[2, 1] == matrix[2, 2] || matrix[0, 0] == "x" && matrix[2, 1] == matrix[2, 0] && matrix[2, 0] != matrix[2, 2])
            //{
            //    tiedGameBoolean = true;
            //    TiedGame();
            //}
            //else
            //{
            //    tiedGameBoolean = false;
            //}
            //if (matrix[0, 0] == "x" && matrix[0, 0] != matrix[1, 0] && matrix[1, 0] == matrix[2, 0] || matrix[0, 0] == "x" && matrix[0, 0] != matrix[1, 0] && matrix[1, 0] != matrix[2, 0] || matrix[0, 0] == "x" && matrix[1, 0] == matrix[0, 0] && matrix[0, 0] == matrix[2, 0])
            //{
            //    tiedGameBoolean = true;
            //    TiedGame();
            //}
            //else
            //{
            //    tiedGameBoolean = false;
            //}
            //if (matrix[0, 1] == "x" && matrix[0, 1] != matrix[1, 1] && matrix[1, 1] == matrix[2, 1] || matrix[0, 0] == "x" && matrix[0, 1] != matrix[1, 1] && matrix[1, 1] != matrix[2, 1] || matrix[0, 0] == "x" && matrix[1, 1] == matrix[0, 1] && matrix[0, 1] == matrix[2, 1])
            //{
            //    tiedGameBoolean = true;
            //    TiedGame();
            //}
            //else
            //{
            //    tiedGameBoolean = false;
            //}
            //if (matrix[0, 2] == "x" && matrix[0, 2] != matrix[1, 2] && matrix[1, 2] != matrix[2, 2] || matrix[0, 0] == "x" && matrix[0, 2] == matrix[1, 2] && matrix[1, 2] != matrix[2, 2] || matrix[0, 0] == "x" && matrix[1, 2] != matrix[0, 2] && matrix[0, 2] == matrix[2, 2])
            //{
            //    tiedGameBoolean = true;
            //    TiedGame();
            //}
            //else
            //{
            //    tiedGameBoolean = false;
            //}
            //if (matrix[0, 0] == "x" && matrix[0, 0] != matrix[1, 1] && matrix[1, 1] != matrix[2, 2] || matrix[0, 0] == "x" && matrix[0, 0] == matrix[1, 1] && matrix[1, 1] != matrix[2, 2] || matrix[0, 0] == "x" && matrix[1, 1] != matrix[0, 0] && matrix[0, 0] == matrix[2, 2])
            //{
            //    tiedGameBoolean = true;
            //    TiedGame();
            //}
            //else
            //{
            //    tiedGameBoolean = false;
            //}
            //if (matrix[0, 2] == "x" && matrix[0, 2] != matrix[1, 1] && matrix[1, 1] != matrix[2, 0] || matrix[0, 0] == "x" && matrix[0, 2] == matrix[1, 1] && matrix[1, 1] != matrix[2, 0] || matrix[0, 0] == "x" && matrix[1, 1] != matrix[0, 2] && matrix[0, 2] == matrix[2, 0])
            //{
            //    tiedGameBoolean = true;
            //    TiedGame();
            //}
            //else
            //{
            //    tiedGameBoolean = false;
            //}




            //if (matrix[0, 0] == "o" && matrix[0, 0] == matrix[0, 1] && matrix[0, 1] != matrix[0, 2] || matrix[0, 0] == "o" && matrix[0, 0] != matrix[0, 1] && matrix[0, 1] == matrix[0, 2] || matrix[0, 0] == "o" && matrix[0, 1] == matrix[0, 0] && matrix[0, 0] != matrix[0, 2])
            //{
            //    tiedGameBoolean = true;
            //    TiedGame();
            //}
            //else
            //{
            //    tiedGameBoolean = false;
            //}

            //if (matrix[1, 0] == "o" && matrix[1, 0] == matrix[1, 1] && matrix[1, 1] != matrix[1, 2] || matrix[0, 0] == "o" && matrix[1, 0] != matrix[1, 1] && matrix[1, 1] == matrix[1, 2] || matrix[0, 0] == "o" && matrix[1, 1] == matrix[1, 0] && matrix[1, 0] != matrix[1, 2])
            //{
            //    tiedGameBoolean = true;
            //    TiedGame();
            //}
            //else
            //{
            //    tiedGameBoolean = false;
            //}
            //if (matrix[2, 0] == "o" && matrix[2, 0] == matrix[2, 1] && matrix[2, 1] != matrix[2, 2] || matrix[0, 0] == "o" && matrix[2, 0] != matrix[2, 1] && matrix[2, 1] == matrix[2, 2] || matrix[0, 0] == "o" && matrix[2, 1] == matrix[2, 0] && matrix[2, 0] != matrix[2, 2])
            //{
            //    tiedGameBoolean = true;
            //    TiedGame();
            //}
            //else
            //{
            //    tiedGameBoolean = false;
            //}
            //if (matrix[0, 0] == "o" && matrix[0, 0] != matrix[1, 0] && matrix[1, 0] == matrix[2, 0] || matrix[0, 0] == "o" && matrix[0, 0] != matrix[1, 0] && matrix[1, 0] != matrix[2, 0] || matrix[0, 0] == "o" && matrix[1, 0] == matrix[0, 0] && matrix[0, 0] == matrix[2, 0])
            //{
            //    tiedGameBoolean = true;
            //    TiedGame();
            //}
            //else
            //{
            //    tiedGameBoolean = false;
            //}
            //if (matrix[0, 1] == "o" && matrix[0, 1] != matrix[1, 1] && matrix[1, 1] == matrix[2, 1] || matrix[0, 0] == "o" && matrix[0, 1] != matrix[1, 1] && matrix[1, 1] != matrix[2, 1] || matrix[0, 0] == "o" && matrix[1, 1] == matrix[0, 1] && matrix[0, 1] == matrix[2, 1])
            //{
            //    tiedGameBoolean = true;
            //    TiedGame();
            //}
            //else
            //{
            //    tiedGameBoolean = false;
            //}
            //if (matrix[0, 2] == "o" && matrix[0, 2] != matrix[1, 2] && matrix[1, 2] != matrix[2, 2] || matrix[0, 0] == "o" && matrix[0, 2] == matrix[1, 2] && matrix[1, 2] != matrix[2, 2] || matrix[0, 0] == "o" && matrix[1, 2] != matrix[0, 2] && matrix[0, 2] == matrix[2, 2])
            //{
            //    tiedGameBoolean = true;
            //    TiedGame();
            //}
            //else
            //{
            //    tiedGameBoolean = false;
            //}
            //if (matrix[0, 0] == "o" && matrix[0, 0] != matrix[1, 1] && matrix[1, 1] != matrix[2, 2] || matrix[0, 0] == "o" && matrix[0, 0] == matrix[1, 1] && matrix[1, 1] != matrix[2, 2] || matrix[0, 0] == "o" && matrix[1, 1] != matrix[0, 0] && matrix[0, 0] == matrix[2, 2])
            //{
            //    tiedGameBoolean = true;
            //    TiedGame();
            //}
            //else
            //{
            //    tiedGameBoolean = false;
            //}
            //if (matrix[0, 2] == "o" && matrix[0, 2] != matrix[1, 1] && matrix[1, 1] != matrix[2, 0] || matrix[0, 0] == "o" && matrix[0, 2] == matrix[1, 1] && matrix[1, 1] != matrix[2, 0] || matrix[0, 0] == "o" && matrix[1, 1] != matrix[0, 2] && matrix[0, 2] == matrix[2, 0])
            //{
            //    tiedGameBoolean = true;
            //    TiedGame();
            //}
            //else
            //{
            //    tiedGameBoolean = false;
            //}

        }

        public static void CheckTheWinner()
        {
            // this for the player 1 who playing X
            if (matrix[0, 0] == "x" && matrix[0, 0] == matrix[0, 1] && matrix[0, 1] == matrix[0, 2])
                winnerPLayerBoolean = true;
            if (matrix[1, 0] == "x" && matrix[1, 0] == matrix[1, 1] && matrix[1, 1] == matrix[1, 2])
                winnerPLayerBoolean = true;
            if (matrix[2, 0] == "x" && matrix[2, 0] == matrix[2, 1] && matrix[2, 1] == matrix[2, 2])
                winnerPLayerBoolean = true;
            if (matrix[0, 0] == "x" && matrix[0, 0] == matrix[1, 0] && matrix[1, 0] == matrix[2, 0])
                winnerPLayerBoolean = true;
            if (matrix[0, 1] == "x" && matrix[0, 1] == matrix[1, 1] && matrix[1, 1] == matrix[2, 1])
                winnerPLayerBoolean = true;
            if (matrix[0, 2] == "x" && matrix[0, 2] == matrix[1, 2] && matrix[1, 2] == matrix[2, 2])
                winnerPLayerBoolean = true;
            if (matrix[0, 0] == "x" && matrix[0, 0] == matrix[1, 1] && matrix[1, 1] == matrix[2, 2])
                winnerPLayerBoolean = true;
            if (matrix[0, 2] == "x" && matrix[0, 2] == matrix[1, 1] && matrix[1, 1] == matrix[2, 0])
                winnerPLayerBoolean = true;
            // This one for the player two who playing the O
            if (matrix[0, 0] == "o" && matrix[0, 0] == matrix[0, 1] && matrix[0, 1] == matrix[0, 2])
                winnerPLayerBoolean = false;
            if (matrix[1, 0] == "o" && matrix[1, 0] == matrix[1, 1] && matrix[1, 1] == matrix[1, 2])
                winnerPLayerBoolean = false;
            if (matrix[2, 0] == "o" && matrix[2, 0] == matrix[2, 1] && matrix[2, 1] == matrix[2, 2])
                winnerPLayerBoolean = false;
            if (matrix[0, 0] == "o" && matrix[0, 0] == matrix[1, 0] && matrix[1, 0] == matrix[2, 0])
                winnerPLayerBoolean = false;
            if (matrix[0, 1] == "o" && matrix[0, 1] == matrix[1, 1] && matrix[1, 1] == matrix[2, 1])
                winnerPLayerBoolean = false;
            if (matrix[0, 2] == "o" && matrix[0, 2] == matrix[1, 2] && matrix[1, 2] == matrix[2, 2])
                winnerPLayerBoolean = false;
            if (matrix[0, 0] == "o" && matrix[0, 0] == matrix[1, 1] && matrix[1, 1] == matrix[2, 2])
                winnerPLayerBoolean = false;
            if (matrix[0, 2] == "o" && matrix[0, 2] == matrix[1, 1] && matrix[1, 1] == matrix[2, 0])
                winnerPLayerBoolean = false;

            if (winnerPLayerBoolean == true)
                winnerPlayer = "Player 1";
            else
                winnerPlayer = "Player 2";

            Console.WriteLine("Congratolaion {0} you have won ", winnerPlayer);
            Console.WriteLine("Please enter anything to restart the game OR enter Close the app");
            string RestartTheGame = Console.ReadLine();
            if (!(RestartTheGame.Equals("Close")))
            {
                gameOverCheck = false;
                matrix = new string[,]
                {
                    {"1","2","3"},
                    {"4","5","6"},
                    {"7","8","9"}
                };
                turnCheck = false;
                SetField();
            }
            else if (RestartTheGame.Equals("Close"))
            {
                Environment.Exit(0);
            }
        }

        public static void TiedGame()
        {
            if (tiedGameBoolean == true)
            {
                tiedGameBoolean = false;
                Console.WriteLine("Tied game !");
                Console.WriteLine("Please enter anything to restart the game OR enter Close the app");
                string RestartTheGame = Console.ReadLine();
                if (!(RestartTheGame.Equals("Close")))
                {
                    gameOverCheck = false;
                    matrix = new string[,]
                    {
                    {"1","2","3"},
                    {"4","5","6"},
                    {"7","8","9"}
                    };
                    turnCheck = false;
                    SetField();
                }
                else if (RestartTheGame.Equals("Close"))
                {
                    Environment.Exit(0);
                }
            }
            

        }

        public static void Garbage()
        {

        }
    }
}