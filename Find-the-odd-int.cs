//Given an array of integers, find the one that appears an odd number of times.
//There will always be only one integer that appears an odd number of times.


using System;
using System.Linq;

namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) => seq.First(x => seq.Count(y => y == x) % 2 != 0);
    }
}
