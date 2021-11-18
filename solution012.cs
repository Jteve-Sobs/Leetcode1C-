// Integer To Roman
// Difficulty: Medium

// Runtime: 88 ms, faster than 64.15% of C# online submissions for Integer to Roman.
// Memory Usage: 39.8 MB, less than 36.58% of C# online submissions for Integer to Roman.

public class Solution {
    public string IntToRoman(int num) {
        switch(num)
        {
            case < 0:
            case > 3999:
                throw new ArgumentOutOfRangeException("Insert value between 1 and 3999"); 
            case < 1:
                return string.Empty;         
            case >= 1000:
                return "M" + IntToRoman(num - 1000);
                break;
            case >= 900:
                return "CM" + IntToRoman(num - 900);
                break;
            case >= 500:
                return "D" + IntToRoman(num - 500);
                break;
            case >= 400:
                return "CD" + IntToRoman(num - 400);
                break;
            case >= 100:
                return "C" + IntToRoman(num - 100);
                break;
            case >= 90:
                return "XC" + IntToRoman(num - 90);
                break;
            case >= 50:
                return "L" + IntToRoman(num - 50);
                break;
            case >= 40:
                return "XL" + IntToRoman(num - 40);
                break;
            case >= 10:
                return "X" + IntToRoman(num - 10);
                break;
            case >= 9:
                return "IX" + IntToRoman(num - 9);
                break;
            case >= 5:
                return "V" + IntToRoman(num - 5);
                break;
            case >= 4:
                return "IV" + IntToRoman(num - 4);
                break;
            case >= 1:
                return "I" + IntToRoman(num - 1);
                break;
            default:
                throw new ArgumentOutOfRangeException("something bad happened"); 
        }
    }
}
