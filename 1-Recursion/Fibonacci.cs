using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGA
{
  public class Fibonacci
  {
    public static int fibonacci_recursive(int n)
    {
      if (n <= 0) return 0;
      if (n == 1) return 1;
      return fibonacci_recursive(n - 1) + fibonacci_recursive(n - 2);
    }

    public static int fibonacci_iterative(int n)
    {
      if (n <= 0) return 0;
      if (n == 1) return 1;

      int a = 0;
      int b = 1;

      for (int i = 2; i <= n; ++i)
      {
        int temp = a + b;
        a = b;
        b = temp;
      }

      return b;

      //var sqrt5 = Math.Sqrt(5);
      //return (int)((Math.Pow(1 + sqrt5, n) - Math.Pow(1 - sqrt5, n)) / (Math.Pow(2, n) * sqrt5));
    }

    public enum Answer { IterativeIsFaster, RecursiveIsFaster };

    public static Answer which_is_faster()
    {
      return Answer.IterativeIsFaster;
      // return Answer.RecursiveIsFaster;
    }
  }
}
