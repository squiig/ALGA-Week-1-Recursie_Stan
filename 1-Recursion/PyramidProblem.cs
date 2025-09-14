using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALGA
{
  public class PyramidProblem
  {
    public static int triangular_number_recursive(int n)
    {
      if (n <= 0) return 0;
      return n + triangular_number_recursive(n - 1);
    }

    public static int triangular_number_iterative(int n)
    {
      if (n < 0) return 0;
      for (int i = n - 1; i > 0; --i)
      {
        n += i;
      }
      return n;
    }

    public static int triangular_number_function(int n)
    {
      return n * (n + 1) / 2;
    }
  }
}
