/*Write simple .camelCase method (camel_case function in PHP, CamelCase in C# or camelCase in Java) for strings. 
All words must have their first letter capitalized without spaces.

For instance:

camelCase("hello case"); // => "HelloCase"
camelCase("camel case word"); // => "CamelCaseWord"
Don't forget to rate this kata! Thanks :)
*/

using System;
using System.Linq;

namespace Kata
{
  public static class Problem
  {
    public static string CamelCase(this string s) => string.Join("", s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select( x => char.ToUpper(x[0]) + new string(x.Skip(1).ToArray())));
  }
}
