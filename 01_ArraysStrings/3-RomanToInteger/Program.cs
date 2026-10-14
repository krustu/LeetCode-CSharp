using System;
class Program
{
    static void Main()
    {
        Solution a = new Solution();
        int result = a.RomanToInt("MCMXCIV");
        Console.WriteLine(result);
    }
}
public class Solution
{
    public int RomanToInt(string s)
    {
        if (s == null) // checking string for null
            return 0;

        int answer = 0; // our final answer 
        s = s.ToUpper(); // upper our string it is need to avoid smt like small word "mcmxciv" instead of "MCMXCIV" etc
        char[] symbols = s.ToCharArray(); // seperate our string into latters 
        for (int a = 0; a < symbols.Length; a++) 
        {

            if (a + 1 < symbols.Length) // cheking for mistakes for example second char could be out of array limits it is need to avoid mistakes 
            {// solving the minus before our main colculations 
                if (symbols[a] == 'C' && symbols[a + 1] == 'M')
                    answer -= 200;
                if (symbols[a] == 'X' && symbols[a + 1] == 'C')
                    answer -= 20;
                if (symbols[a] == 'I' && symbols[a + 1] == 'V')
                    answer -= 2;
                if (symbols[a] == 'I' && symbols[a + 1] == 'X')
                    answer -= 2;
                if (symbols[a] == 'X' && symbols[a + 1] == 'L')
                    answer -= 20;
                if (symbols[a] == 'C' && symbols[a + 1] == 'D')
                    answer -= 200;
            }

            switch (symbols[a])// Main colcultions
            { // translator Roman char to int 
                case 'I':
                    answer += 1;
                    break;
                case 'V':
                    answer += 5;
                    break;
                case 'X':
                    answer += 10;
                    break;
                case 'L':
                    answer += 50;
                    break;
                case 'C':
                    answer += 100;
                    break;
                case 'D':
                    answer += 500;
                    break;
                case 'M':
                    answer += 1000;
                    break;
                default:
                    answer += 0;
                    break;
            }
        }
        return answer;
    }
}
//I             1
//V             5
//X             10
//L             50
//C             100
//D             500
//M             1000