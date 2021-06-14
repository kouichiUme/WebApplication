using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.model
{
    public class DynamicPlanning
    {







        public int[][][] matrixCahinOrder(int[] p)
        {

            int n = p.Length -1;



            int[][] m = new int[10][];
            int[][] s = new int[10][];

            for (int i = 1; i < n; i++)
            {
                m[i][i] = 0;
            }

            for (int l = 2; l < n; l++)
            {
                for (int i = 1; i < n - l + 1; i++)
                {
                    int j = i + l -1;
                    m[i][j] = int.MaxValue;

                    for (int k = i; k< j-1; k++)
                    {
                        int q = m[i][k] + m[k+1][j] + p[i-1] * p[k] * p[j];
                        if (q < m[i][j])
                        {
                            m[i][j] =  q;
                            s[i][j] = k;
                        }
                    }

                }
            }


            int[][][] a = new int[2][][];
            a[0] = m;
            a[1] = s;
            return a;
        }
    }
}
