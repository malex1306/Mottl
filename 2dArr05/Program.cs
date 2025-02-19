class Program
{
    static void Main()
    {
        int[,,] bloecke = new int[9, 3, 3];
        int[,] sudoku = new int[9, 9];

        EingabeSudoku(sudoku);
        SudokuAnzeigen(sudoku);

        if (IstSudokuGueltig(sudoku))
        {
            Console.WriteLine("Das Sudoku ist gültig!");
        }
        else
        {
            Console.WriteLine("Das Sudoku ist ungültig!");
        }
    }

    static void EingabeSudoku(int[,] sudoku)
    {
        Console.WriteLine("Geben Sie das Sudoku ein (Zeile für Zeile, 9 Zahlen pro Zeile, getrennt durch Leerzeichen):");
        for (int zeile = 0; zeile < 9; zeile++)
        {
            string input = Console.ReadLine();
            string[] zahlen = input.Split(' ');
            for (int spalte = 0; spalte < 9; spalte++)
            {
                sudoku[zeile, spalte] = int.Parse(zahlen[spalte]);
            }
        }
    }

    static void SudokuAnzeigen(int[,] sudoku)
    {
        Console.WriteLine("Sudoku:");
        for (int zeile = 0; zeile < 9; zeile++)
        {
            if (zeile % 3 == 0 && zeile != 0)
                Console.WriteLine("------+-------+------");

            for (int spalte = 0; spalte < 9; spalte++)
            {
                if (spalte % 3 == 0 && spalte != 0)
                    Console.Write(" | ");
                Console.Write(sudoku[zeile, spalte] + " ");
            }
            Console.WriteLine();
        }
    }

    static bool IstSudokuGueltig(int[,] sudoku)
    {
        bool gueltig = true;
        
        // Zeilen und Spalten prüfen
        for (int i = 0; i < 9; i++)
        {
            if (!IstBereichGueltig(sudoku, i, 0, 0, 1))
                gueltig = false;
            if (!IstBereichGueltig(sudoku, 0, i, 1, 0))
                gueltig = false;
        }
        
        // Blöcke prüfen
        for (int blockZeile = 0; blockZeile < 3; blockZeile++)
        {
            for (int blockSpalte = 0; blockSpalte < 3; blockSpalte++)
            {
                if (!IstBereichGueltig(sudoku, blockZeile * 3, blockSpalte * 3, 1, 1))
                    gueltig = false;
            }
        }
        
        return gueltig;
    }

    static bool IstBereichGueltig(int[,] sudoku, int startZeile, int startSpalte, int zeilenSchritt, int spaltenSchritt)
    {
        HashSet<int> zahlen = new HashSet<int>();
        for (int i = 0; i < 9; i++)
        {
            int zahl = sudoku[startZeile + i / 3 * zeilenSchritt, startSpalte + i % 3 * spaltenSchritt];
            if (zahl != 0)
            {
                if (zahlen.Contains(zahl))
                {
                    Console.WriteLine($"Doppelte Zahl {zahl} gefunden in Zeile {startZeile + i / 3 + 1}, Spalte {startSpalte + i % 3 + 1}");
                    return false;
                }
                zahlen.Add(zahl);
            }
        }
        return true;
    }
}
