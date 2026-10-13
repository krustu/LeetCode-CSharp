using System;
using System.ComponentModel.Design;
class Program
{
    static void Main()
    {
        int num = -12321;
        Solution a = new();
        bool result = a.IsPalindrome(num);
        Console.WriteLine(result);
    }
}
public class Solution
{

    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;
        List<int> digits = new();
        List<int> basic = new();
        while (x > 0)
        {
            digits.Add(x % 10);
            basic.Add(x % 10);
            x /= 10;

        }
        digits.Reverse();
        for (var a = 0; a < digits.Count; a++)
        {
            if (digits[a] != basic[a])
            {
                return false;
            }
        }
        return true;

    }

}
