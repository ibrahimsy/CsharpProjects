using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TestGitHub
{
    class Program
    {
        //Lambda Exprission
        delegate int lamdaDelegate(int x);
        static void Main(string[] args)
        {
            int[] arr = { 3, 21, 4, 8, 10, 11, 18 };
            lamdaDelegate ld = x => (x > 10) ? x : -1;
            Func<int, int> moreThanTen = x => (x > 10) ? x : -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (moreThanTen.Invoke(arr[i]) == -1)
                    continue;
                WriteLine(moreThanTen.Invoke(arr[i]));
            }
        }
    }
}
