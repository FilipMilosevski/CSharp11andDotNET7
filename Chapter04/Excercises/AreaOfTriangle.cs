using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises
{
    public static class AreaOfTriangle
    {

        public static int Triangle(int parametar1, int parametar2)
        {
            int res = (parametar1 * parametar2) / 2;
            return res;
        }
        public static int Minutes(int par)
        {
            int res = (par * 60);
            return res;

        }
        public static bool Equal(int p)
        {
            if (p <= 0) return true;
            else
            {
                return false;
            }
        }
       
        public static string Something(string par)
        {
            return "something" + par;
        }

       
        public static bool TrueFalse(bool par)
        {
            if (par == true)
            {
                return false;
            }
            else { return true; }
        }
       
        public static bool NumbersTrueFalse(int p1, int p2)
        {
            if (p1 == p2)
            {
                return true;
            } else { 
                return false;
            }
        }
        
        public static int Basketball(int par1, int par2)
        {
            int res1 = par1 * 2;
            int res2 = par2 * 3;
            return res1 + res2;

        }
         public static void Sum(int num, string name)
        {
            int total = (num * 60);
            var s = total + name;
            Console.WriteLine(s);
        }
        public static void sum1(int n, string name)
        {
            int total = n * 60;
            Console.WriteLine(total + name);
        }

    }



}
