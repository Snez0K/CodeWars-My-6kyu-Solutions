/*
Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.

Example:
Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
The returned format must be correct in order to complete this challenge.
Don't forget the space after the closing parentheses!
*/

using System.Text.RegularExpressions;
using System.Linq;

//Regex Solution (1)
public class Kata
{
  public static string CreatePhoneNumber(int[] numbers)
  {
    string s = string.Join("", numbers);
    Regex regex = new Regex("([0-9]{3})([0-9]{3})([0-9]{4})"); 
    var match = regex.Match(s);
    return "(" + match.Groups[1].Value + ") " + match.Groups[2].Value + "-" + match.Groups[3].Value;
  }
}


//LinQ Solution (2)
public class Kata
{
  public static string CreatePhoneNumber(int[] numbers)
  {
    return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
  }
}
