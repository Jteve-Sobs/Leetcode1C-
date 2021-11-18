// Roman to Integer
// Difficulty: Easy

// Runtime: 80 ms, faster than 71.79% of C# online submissions for Roman to Integer.
// Memory Usage: 39.6 MB, less than 12.75% of C# online submissions for Roman to Integer.

public class Solution {
    public static readonly Dictionary<char, int> RomanNumberDictionary = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };
    
    public int RomanToInt(string s) {
        
        int total = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i + 1 < s.Length && RomanNumberDictionary[s[i]] < RomanNumberDictionary[s[i + 1]])
            {
                total -= RomanNumberDictionary[s[i]];
            }
            else
            {
                total += RomanNumberDictionary[s[i]];
            }
        }
        
        return total;
    }
}
