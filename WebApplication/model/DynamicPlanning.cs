using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

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


        public String printOptionalParens(int[][] s, int i,int j)
        {
            StringBuilder  sb = new StringBuilder();

            if (i ==j)
            {
                 sb.Append("A" + i);

            }
            else
            {
                sb.Append("(");

                sb.Append(printOptionalParens(s, i, s[i][j]));
                sb.Append(printOptionalParens(s, s[i][j]+1, j));

                sb.Append(")");

            }


            return sb.ToString();

        }

        public int memorizedMatrixChgain(int[] p)
        {

            int n = p.Length - 1;


            int[][] m = new int[10][];

            for(int i = 0; i <= n; i++)
            {
                for(int j = 0; j <= n; j++)
                {
                    m[i][j] = int.MaxValue;
                }
            }


            return lookupChain(m, p, 1, n);

        }

        public int lookupChain(int[][] m ,int[] p,int i , int j)
        {
            if(m[i][j] < int.MaxValue)
            {
                return m[i][j];
            }
            if(i == j)
            {
                m[i][j]=0;
            }
            else
            {
                for (int k = i; k < j; k++)
                {
                    int q = lookupChain(m, p, i, k) + lookupChain(m, p, k+1, j) + p[i-1]*p[k]*p[j];

                    if (q < m[i][j])
                    {
                        m[i][j]=q;
                    }
                }

            }


            return m[i][j];
        }


        public void longestCommonSubsequence(int[] x, int[] y)
        {
            int m = x.Length;
            int n = y.Length;

            char[][] b = new char[m][];
            int[][] c = new int[m][];

            for (int i = 1; i<m; i++)
            {
                c[i][0] = 0;
            }
            for (int i = 0; i < n; ++i)
            {
                c[0][i] =0;
            }


            for (int i = 1; i<m; ++i)
            {

                for (int j = 1; j < n; ++j)
                {



                    if (x[i]==y[j])
                    {
                        c[i][j] = c[i-1][j-1]+1;
                        b[i][j] = 'h';



                    }
                    else if (c[i-1][j] >=c[i][j-1])
                    {

                        c[i][j] =c[i-1][j];
                        b[i][j] = 'u';



                    }
                    else
                    {
                        c[i][j] = c[i][j-1];
                        b[i][j] = 'l';

                    }

                }





            }

            // c,bが結果になる


            return;

        }


        public void optimalBinarySearchTree(int p ,int q ,int n)
        {



            int[][] e, w, root;

            e = new int[10][];
            w = new int[10][];
            root = new int[10][];


            for(int i = 1; i < n+1; i++)
            {

            }
        }


        public int[] greed(int[] M , int[] w)
        {

            int[] g = null;


            for (int i = 0; i< w.Length; i++){

                // m.
                // if (M.T.contains(g, w[i]){
                    // g.append(w[i])
                       ;
               // }
            }
            


            return g;
        }
    }


}
