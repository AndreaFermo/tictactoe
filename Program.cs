using System.Numerics;

namespace tictactoe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int turn = 0;
            string[,] board = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
            string playerOne = "X";
            string playerTwo = "O";
            bool changeTurn = true;
            bool win = false;

            generateBoard(board);

            while (turn < 10 && win == false) {
                if (turn < 9)
                {
                    string playerInTurn = changeTurn ? playerOne : playerTwo;



                    Console.WriteLine("Tocca al giocatore {0}! digita un numero disponibilie e premi invio!", playerInTurn);
                    string digit = Console.ReadLine();
                    changeValueOnTheBoard(digit, playerInTurn, board);
                    Console.Clear();
                    changeTurn = !changeTurn;
                    turn++;
                    generateBoard(board);
                    win = check(board);
                }
                else {
                    Console.WriteLine("pareggio!!!!!!!!");
                    break;
                }
                


            }
           

        }

        public static void generateBoard(string[,] board)
        { 
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[0,0], board[0,1], board[0,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[1,0], board[1,1], board[1,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[2,0], board[2,1], board[2,2]);
            Console.WriteLine("     |     |     ");
        }

        public static void changeValueOnTheBoard(string digit, string player, string[,] board)
        {
            switch (digit)
            {
                case "1":
                    board[0,0] = player;
                    break;
                case "2":
                    board[0,1] = player;
                    break;
                case "3":
                    board[0,2] = player;
                    break;
                case "4":
                    board[1,0] = player;
                    break;
                case "5":
                    board[1,1] = player;
                    break;
                case "6":
                    board[1,2] = player;
                    break;
                case "7":
                    board[2,0] = player;
                    break;
                case "8":
                    board[2,1] = player;
                    break;
                case "9":
                    board[2,2] = player;
                    break;
            }
        }


        public static bool check(string[,] board)
        {

            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    Console.WriteLine("partita conclusa!");
                    return true;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    Console.WriteLine("partita conclusa!");
                    return true;
                }
            }


            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                Console.WriteLine("partita conclusa!");
                return true;
            }

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                Console.WriteLine("partita conclusa!");
                return true;
            }


            return false;


        }
    }
}