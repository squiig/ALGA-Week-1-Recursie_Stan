using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ALGA
{
  public class StringReverse
  {
    public static String string_reverse(String s)
    {
      if (s.Length <= 1) return s;

      return string_reverse(s.Substring(1)) + s[0];
    }

    public static bool is_palindrome(String s)
    {
      if (s.Length < 2) return true;
      return s[0].Equals(s[s.Length - 1]) && is_palindrome(s.Substring(1, s.Length - 2));
    }
  }
}
