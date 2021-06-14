using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Solution
    {
        public List<int> PrintMatrixSpiral(int[,] matrix)
        {
            List<int> res = new List<int>();
            int R = matrix.GetLength(0), C = matrix.GetLength(1);
            bool[,] seen = new bool[R, C];
            int[] dr = { 0, 1, 0, -1 };
            int[] dc = { 1, 0, -1, 0 };
            int r = 0, c = 0, di = 0;
            for (int i = 0; i < R * C; i++)
            {
                res.Add(matrix[r, c]);
                seen[r, c] = true;
                int cr = r + dr[di];
                int cc = c + dc[di];
                if (0 <= cr && cr < R && 0 <= cc && cc < C && !seen[cr,cc])
                {
                    r = cr;
                    c = cc;
                }
                else
                {
                    di = (di + 1) % 4;
                    r += dr[di];
                    c += dc[di];
                }
            }

            return res;
        }
    }
}
