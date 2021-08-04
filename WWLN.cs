using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Apple_Software
{
    class WWLN
    {
        int[] a, b ,c;
        string s;
        int i;
        public string Sum(string x, string y)
        {
            
            a = new int[x.Length];
            b = new int[y.Length];

            //......................
            i = a.Length;
            foreach (char ch in x)
            {
                i--;
                a[i] = Convert.ToInt32(ch.ToString());
            }

            //......................
            i = b.Length;
            foreach (char ch in y)
            {
                i--;
                b[i] = Convert.ToInt32(ch.ToString());
            }

            i = x.Length > y.Length ? x.Length : y.Length;
            c = new int[i+1];
            for (int k = 0; k < c.Length; k++)
                c[k] = 0;
            //......................................................
            //......................................................

            for (int j = 0; j < c.Length-1; j++)
            {
                if (j < a.Length & j < b.Length)
                {
                    if (a[j] + b[j] + c[j] < 10)
                    {
                        c[j] = a[j] + b[j];
                    }
                    else if (a[j] + b[j] + c[j] >= 10)
                    {
                        c[j] += (a[j] + b[j]) - 10;
                        c[j + 1] += 1;
                    }
                }
                else if (j >= a.Length & j < b.Length)
                {
                    c[j] += b[j];
                }
                else if (j < a.Length & j >= b.Length)
                {
                    c[j] += a[j];
                }
            }

            s = null;
            for (int j = c.Length - 1; j >= 0; j--)
            {
                s += c[j].ToString();
            }
           
            return s;
        }
    }
}
