using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static char[,] TicTacToeArray = new char[,]
  {
                {'1','2','3' },
                {'4','5','6' },
                {'7','8','9' }
};
        
        static int turns = 0;

        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool input_correct = true;
            Console.WriteLine("Welcome to Tic Tac Toe");
            


            do
            {
                
                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if (player==1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }
                SetField();

                char[] playerChars = { 'X', 'O' };

                foreach (char playerChar in playerChars)
                {
                    if (TicTacToeArray[0, 0] == playerChar && TicTacToeArray[0, 1] == playerChar && (TicTacToeArray[0, 2] == playerChar)
                  || (TicTacToeArray[1, 0] == playerChar) && (TicTacToeArray[1, 1] == playerChar) && (TicTacToeArray[1, 2] == playerChar)
                  || (TicTacToeArray[2, 0] == playerChar) && (TicTacToeArray[2, 1] == playerChar) && (TicTacToeArray[2, 2] == playerChar)
                  || (TicTacToeArray[0, 0] == playerChar) && (TicTacToeArray[1, 1] == playerChar) && (TicTacToeArray[2, 2] == playerChar)
                  || (TicTacToeArray[0, 2] == playerChar) && (TicTacToeArray[1, 1] == playerChar) && (TicTacToeArray[2, 0] == playerChar)

                  || (TicTacToeArray[0, 0] == playerChar) && (TicTacToeArray[1, 0] == playerChar) && (TicTacToeArray[2, 0] == playerChar)

                  || (TicTacToeArray[0, 1] == playerChar) && (TicTacToeArray[1, 1] == playerChar) && (TicTacToeArray[2, 1] == playerChar)

                 || (TicTacToeArray[0, 2] == playerChar) && (TicTacToeArray[1, 2] == playerChar) && (TicTacToeArray[2, 2] == playerChar)
                 )
                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("\nPlayer 2 has won!!");
                        }
                        else
                        {
                            Console.WriteLine("\nPlayer 1 has won!!");
                        }

                        Console.WriteLine("Please press any key to reset the game");
                        Console.ReadKey();
                        ResetField();
                       

                        break;
                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("Its a Draw!!");
                        Console.WriteLine("Please press any key to reset the game.");
                        Console.ReadKey();
                        ResetField();

                        break;
                    }
                }

                do

                {
                    Console.WriteLine("\n Player {0}: Choose your field", player);
                    try {
                       
                        input = Convert.ToInt32((Console.ReadLine()));
                    }
                    catch
                    {
                        Console.WriteLine("Please enter the correct value i.e Number only");
                    }
                    if ((input == 1) && (TicTacToeArray[0, 0] == '1'))
                    
                        input_correct = true;
                    
                    else if ((input == 2) && (TicTacToeArray[0, 1] == '2'))
                        {
                        input_correct = true;
                    }
                    else if ((input == 3) && (TicTacToeArray[0, 2] == '3')){
                        input_correct = true;
                    }
                    else if ((input == 4) && (TicTacToeArray[1, 0] == '4')){
                        input_correct = true;
                    }
                    else if ((input == 5) && (TicTacToeArray[1, 1] == '5')){
                        input_correct = true;
                    }
                    else if ((input == 6) && (TicTacToeArray[1, 2] == '6')){
                        input_correct = true;
                    }
                    else if ((input == 7) && (TicTacToeArray[2, 0] == '7')){
                        input_correct = true;
                    }

                    else if ((input == 8) && (TicTacToeArray[2, 1] == '8'))
                    {
                        input_correct = true;
                    }

                    else if ((input == 9) && (TicTacToeArray[2, 2] == '9'))
                    {
                        input_correct = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Input!! Please correct another field   ");
                        input_correct = false;
                    }
                }
                while (!input_correct);

                {

                }
                 
                
            }
            while (true);
        
    }

        public static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';

            if (player == 1)
                playerSign = 'X';
            else if (player==2)
                playerSign = 'O';

            switch (input)
            {
                case 1: TicTacToeArray[0, 0] = playerSign; break;
                case 2: TicTacToeArray[0, 1] = playerSign; break;
                case 3: TicTacToeArray[0, 2] = playerSign; break;
                case 4: TicTacToeArray[1, 0] = playerSign; break;
                case 5: TicTacToeArray[1, 1] = playerSign; break;
                case 6: TicTacToeArray[1, 2] = playerSign; break;
                case 7: TicTacToeArray[2, 0] = playerSign; break;
                case 8: TicTacToeArray[2, 1] = playerSign; break;
                case 9: TicTacToeArray[2, 2] = playerSign; break;
                            }
        }
       public static void ResetField()
        {
            char[,] TicTacToeArray_intial = new char[,]
  {
                {'1','2','3' },
                {'4','5','6' },
                {'7','8','9' }
};
            TicTacToeArray =TicTacToeArray_intial;

            SetField();
            turns = 0;
        }

        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("    |    |    ");
            Console.WriteLine(" {0}  | {1}  |  {2}", TicTacToeArray[0, 0], TicTacToeArray[0, 1], TicTacToeArray[0, 2]);
            Console.WriteLine("____|____|____");
            Console.WriteLine("    |    |    ");
            Console.WriteLine(" {0}  | {1}  |  {2}", TicTacToeArray[1, 0], TicTacToeArray[1, 1], TicTacToeArray[1, 2]);
            Console.WriteLine("____|____|____");
            Console.WriteLine("    |    |    ");
            Console.WriteLine(" {0}  | {1}  |  {2}", TicTacToeArray[2, 0], TicTacToeArray[2, 1], TicTacToeArray[2, 2]);
            Console.WriteLine("____|____|____");
            turns++;
        }
       
    }
    }




    
