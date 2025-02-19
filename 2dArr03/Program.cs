namespace TicTacToeGame
{
    class Program
    {
        static char[,] board = 
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };

        static char startPlayer = 'X'; 

        static void Main(string[] args)
        {
            int moves = 0;
            bool gameRunning = true;

            while (gameRunning)
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine($"Spieler {startPlayer}, wähle eine Position (1-9):");
                string input = Console.ReadLine();

                if (MakeMove(input))
                {
                    moves++;

                    if (CheckWin())
                    {
                        Console.Clear();
                        DrawBoard();
                        Console.WriteLine($"Spieler {startPlayer} hat gewonnen!");
                        gameRunning = false;
                    }
                    else if (moves == 9)
                    {
                        Console.Clear();
                        DrawBoard();
                        Console.WriteLine("Unentschieden!");
                        gameRunning = false;
                    }
                    else
                    {
                        SwitchPlayer();
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte versuche es erneut.");
                    Console.ReadLine();
                }
            }
        }

        static void DrawBoard()
        {
            Console.WriteLine("Tic Tac Toe:");
            Console.WriteLine("-------------");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] + " | ");
                }
                Console.WriteLine();
                Console.WriteLine("-------------");
            }
        }

        static bool MakeMove(string input)
        {
            int position;
            if (!int.TryParse(input, out position) || position < 1 || position > 9)
            {
                return false;
            }

            int row = (position - 1) / 3;
            int col = (position - 1) % 3;

            if (board[row, col] == 'X' || board[row, col] == 'O')
            {
                return false; //feld belegt
            }

            board[row, col] = startPlayer;
            return true;
        }

        static void SwitchPlayer()
        {
            startPlayer = (startPlayer == 'X') ? 'O' : 'X';
        }

        static bool CheckWin()
        {
            for (int i = 0; i < 3; i++)
            {
                //Zeilen und Spalten
                if ((board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2]) ||
                    (board[0, i] == board[1, i] && board[1, i] == board[2, i]))
                {
                    return true;
                }
            }

            //Diagonal
            if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) ||
                (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]))
            {
                return true;
            }

            return false;
        }
    }
}
