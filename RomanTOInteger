public class Solution {

public static void Main()
{
  string st ="III";
  RomanToInt(st);
  
}

    public int RomanToInt(string s) {
         int totalValue = 0, prevValue = 0;
            foreach (var c in s)
            {
                if (!_roman.ContainsKey(c))
                    return 0;
                var crtValue = _roman[c];
                totalValue += crtValue;
                if (prevValue != 0 && prevValue < crtValue)
                {
                    if (prevValue == 1 && (crtValue == 5 || crtValue == 10)
                        || prevValue == 10 && (crtValue == 50 || crtValue == 100)
                        || prevValue == 100 && (crtValue == 500 || crtValue == 1000))
                        totalValue -= 2 * prevValue;
                    else
                        return 0;
                }
                prevValue = crtValue;
            }
            return totalValue;
        
    }
    
     public static Dictionary<char, int> _roman = new Dictionary<char, int>
        {
            {'I',1},{'V',5},{'X',10},{'L',50},{'C', 100}, {'D', 500}, {'M', 1000}
        };
}
}
