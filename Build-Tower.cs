/*Build Tower
Build Tower by the following given argument:
number of floors (integer and always greater than 0).
Tower block is represented as *
C#: returns a string[];
and a tower of 6 floors looks like below

[
  '     *     ', 
  '    ***    ', 
  '   *****   ', 
  '  *******  ', 
  ' ********* ', 
  '***********'
]*/

public class Kata
{
  public static string[] TowerBuilder(int nFloors)
  {
    string[] x = new string[nFloors];
    
    for (int i = nFloors -1; i >= 0; i--)
            {
                for (int p = 0; p <= i * 2; p++)
                    x[i] += "*";
                for (int k = 0; k < nFloors - i -1; k++)
                {
                    x[i] += " ";
                    x[i] = x[i].Insert(0, " ");
                }
            }
    return x;
  }
}
