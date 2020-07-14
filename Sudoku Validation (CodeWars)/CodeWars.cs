using System.Linq;
class Sudoku
    {
        public static bool ValidateSolution(int[][] board)
        {
            int[][] Sudoku = board;
            //Verifica valores
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Sudoku[i][j] > 9 || Sudoku[i][j] < 0)
                    {
                        return false;
                    }
                }
            }
            //Verifica Linhas
            for (int i = 0; i < 9; i++)
            {
                int[] Verifica = new int[9];
                for (int j = 0; j < 9; j++)
                {
                    Verifica[j] = Sudoku[i][j];
                }
                if (Verifica.Length != Verifica.Distinct().Count())
                {
                    return false;
                }
            }
            //Verifica Colunas
            for (int i = 0; i < 9; i++)
            {
                int[] Verifica = new int[9];
                for (int j = 0; j < 9; j++)
                {
                    Verifica[j] = Sudoku[j][i];
                }
                if (Verifica.Length != Verifica.Distinct().Count())
                {
                    return false;
                }
            }
            //Bloco 1   Linha 0 - 2  Coluna 0 - 2
            if (VerificaBloco(0, 0, 3, 3, Sudoku) == false)
                return false;
            //Bloco 2  Linha 0 - 2   Coluna 3 - 5
            if (VerificaBloco(0, 3, 3, 6, Sudoku) == false)
                return false;
            //Bloco 3  Linha 0 - 2   Coluna 6 - 8
            if (VerificaBloco(0, 6, 3, 9, Sudoku) == false)
                return false;
            //Bloco 4  Linha 3 - 5   Coluna 0 - 2
            if (VerificaBloco(3, 0, 6, 3, Sudoku) == false)
                return false;
            //Bloco 5  Linha 3 - 5   Coluna 3 - 5
            if (VerificaBloco(3, 3, 6, 6, Sudoku) == false)
                return false;
            //Bloco 6  Linha 3 - 5   Coluna 6 - 8
            if (VerificaBloco(3, 6, 6, 9, Sudoku) == false)
                return false;
            //Bloco 7  Linha 6 - 8   Coluna 0 - 2
            if (VerificaBloco(6, 0, 9, 3, Sudoku) == false)
                return false;
            //Bloco 8  Linha 6 - 8   Coluna 3 - 5
            if (VerificaBloco(6, 3, 9, 6, Sudoku) == false)
                return false;
            //Bloco 9  Linha 6 - 8   Coluna 6 - 8
            if (VerificaBloco(6, 6, 9, 9, Sudoku) == false)
                return false;


            return true;

        }
        public static bool VerificaBloco(int I, int J, int IK, int JK, int[][] Sudoku)
        {
            int S = 0;
            int[] Vetor = new int[9];
            for (int i = I; i < IK; i++)
            {
                for (int j = J; j < JK; j++)
                {
                    Vetor[S] = Sudoku[i][j];
                    S++;
                }
            }
            if (Vetor.Length != Vetor.Distinct().Count())
            {
                return false;
            }
            return true;
        }
    }