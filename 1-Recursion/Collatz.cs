using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGA
{

  public class Collatz
  {
    public static int collatz_recursive(int n)
    {
      if (n <= 0) return -1;
      if (n == 1) return 0;
      
      if (n % 2 == 0)
      {
        return 1 + collatz_recursive(n / 2);
      }
      else
      {
        return 1 + collatz_recursive(n * 3 + 1);
      }
    }

    public static int collatz_iterative(int n)
    {
      if (n <= 0) return -1;
      if (n == 1) return 0;

      int steps = 0;
      while (n != 1)
      {
        if (n % 2 == 0)
        {
          n /= 2;
        }
        else
        {
          n = n * 3 + 1;
        }

        ++steps;
      }

      return steps;
    }
  }
}
