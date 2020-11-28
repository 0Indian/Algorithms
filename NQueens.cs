using System;
using System.Collections.Generic;
using System.Text;

namespace Prep
{
    public class NQueens
    {
        List<IList<string>> list = new List<IList<string>>();
        int N = 0;
        public IList<IList<string>> SolveNQueens(int n)
        {
            N = n;
            char[,] board = new char[n, n];
            board = initializeArray(board);

            if (n == 0) return list;

            NQueensUtil(board, 0);

            if (n == 1)
            {
                return list as IList<IList<string>>;
            }
            char[,] clone = board;
            //clone = board;
            int i = 0, j = 0;
            while (i < N)
            {
                j = 0;
                while (j < N)
                {
                    if (clone[i, j] == 'Q')
                    {
                        clone[i, j] = '.';
                        clone[i, N - j - 1] = 'Q';
                        i++;
                        break;
                    }
                    j++;
                }
            }
            AddBoardToList(clone);


            return list as IList<IList<string>>;
        }
        private bool NQueensUtil(char[,] board, int col)
        {
            if (col >= N)
            {
                AddBoardToList(board);
                return true;
            }

            for (int i = 0; i < N; i++)
            {

                if (IsSafe(board, i, col))
                {
                    board[i, col] = 'Q';


                    if (NQueensUtil(board, col + 1))
                        return true;

                    board[i, col] = '.';
                }

            }
            return false;

        }
        private void AddBoardToList(char[,] array)
        {
            int i = 0;
            List<string> listLocal = new List<string>();
            for (i = 0; i < N; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < N; j++)
                {
                    sb.Append(array[i, j]);
                }
                listLocal.Add(sb.ToString());
            }
            list.Add(listLocal);
        }
        private char[,] initializeArray(char[,] array)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = '.';
                }
            }
            return array;
        }
        public bool IsSafe(char[,] board, int row, int col)
        {
            int i, j;
            for (i = 0; i < col; i++)
            {
                if (board[row, i] == 'Q') return false;
            }

            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 'Q') return false;
            }

            for (i = row, j = col; i < N && j >= 0; i++, j--)
            {
                if (board[i, j] == 'Q')
                    return false;
            }
            return true;
        }
    }
}
