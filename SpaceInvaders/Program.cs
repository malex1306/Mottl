class Tetris
{
    static int width = 10, height = 20;
    static int[,] field = new int[width, height];
    static int[,] currentPiece;
    static int pieceX, pieceY;
    static Random rand = new Random();
    static bool gameOver = false;

    static int[][,] pieces = new int[][,]
    {
        new int[,] { { 1, 1, 1, 1 } }, // I-Block
        new int[,] { { 1, 1 }, { 1, 1 } }, // O-Block
        new int[,] { { 0, 1, 1 }, { 1, 1, 0 } }, // S-Block
        new int[,] { { 1, 1, 0 }, { 0, 1, 1 } }, // Z-Block
        new int[,] { { 1, 0 }, { 1, 1 }, { 1, 0 } }, // T-Block
        new int[,] { { 1, 1, 1 }, { 1, 0, 0 } }, // L-Block
        new int[,] { { 1, 1, 1 }, { 0, 0, 1 } } // J-Block
    };

    static void Main()
    {
        Console.CursorVisible = false;
        SpawnPiece();
        Thread inputThread = new Thread(Input);
        inputThread.Start();

        while (!gameOver)
        {
            Draw();
            MovePiece(0, 1);
            CheckLines();
            Thread.Sleep(500);
        }

        Console.Clear();
        Console.WriteLine("GAME OVER!");
    }

    static void Input()
    {
        while (!gameOver)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.A) MovePiece(-1, 0);
                if (key == ConsoleKey.D) MovePiece(1, 0);
                if (key == ConsoleKey.S) DropPiece();
                if (key == ConsoleKey.W) RotatePiece();
                if (key == ConsoleKey.Q) gameOver = true;
            }
            Thread.Sleep(50);
        }
    }

    static void SpawnPiece()
    {
        currentPiece = pieces[rand.Next(pieces.Length)];
        pieceX = width / 2 - currentPiece.GetLength(1) / 2;
        pieceY = 0;

        if (!IsValidMove(pieceX, pieceY, currentPiece))
            gameOver = true;
    }

    static void MovePiece(int dx, int dy)
    {
        if (IsValidMove(pieceX + dx, pieceY + dy, currentPiece))
            pieceX += dx;
        else if (dy > 0)
        {
            MergePiece();
            SpawnPiece();
        }
    }

    static void RotatePiece()
    {
        int[,] rotated = new int[currentPiece.GetLength(1), currentPiece.GetLength(0)];
        for (int y = 0; y < currentPiece.GetLength(0); y++)
            for (int x = 0; x < currentPiece.GetLength(1); x++)
                rotated[x, currentPiece.GetLength(0) - 1 - y] = currentPiece[y, x];

        if (IsValidMove(pieceX, pieceY, rotated))
            currentPiece = rotated;
    }

    static void MergePiece()
    {
        for (int y = 0; y < currentPiece.GetLength(0); y++)
            for (int x = 0; x < currentPiece.GetLength(1); x++)
                if (currentPiece[y, x] == 1)
                    field[pieceX + x, pieceY + y] = 1;
    }

    static void CheckLines()
    {
        for (int y = height - 1; y >= 0; y--)
        {
            bool full = true;
            for (int x = 0; x < width; x++)
                if (field[x, y] == 0) full = false;

            if (full)
            {
                for (int ny = y; ny > 0; ny--)
                    for (int x = 0; x < width; x++)
                        field[x, ny] = field[x, ny - 1];
                y++;
            }
        }
    }

    static bool IsValidMove(int newX, int newY, int[,] shape)
    {
        for (int y = 0; y < shape.GetLength(0); y++)
            for (int x = 0; x < shape.GetLength(1); x++)
                if (shape[y, x] == 1)
                {
                    int fx = newX + x, fy = newY + y;
                    if (fx < 0 || fx >= width || fy >= height || (fy >= 0 && field[fx, fy] == 1))
                        return false;
                }
        return true;
    }
    
    static void DropPiece()
    {
        while (IsValidMove(pieceX, pieceY + 1, currentPiece))
        {
            pieceY++;
        }
        MergePiece();
        SpawnPiece();
    }


    static void Draw()
    {
        Console.Clear();

        // Zeichne Spielfeld
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Console.SetCursorPosition(x * 2, y);
                Console.Write(field[x, y] == 1 ? "■" : " ");
            }
        }

        // Zeichne aktuelles Stück
        for (int y = 0; y < currentPiece.GetLength(0); y++)
        {
            for (int x = 0; x < currentPiece.GetLength(1); x++)
            {
                if (currentPiece[y, x] == 1)
                {
                    Console.SetCursorPosition((pieceX + x) * 2, pieceY + y);
                    Console.Write("■");
                }
            }
        }
    }
}
