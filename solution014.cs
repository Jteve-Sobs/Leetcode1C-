// Valid Parentheses
// Difficulty: Easy

// Runtime: 68 ms, faster than 95.13% of C# online submissions for Valid Parentheses.
// Memory Usage: 37.4 MB, less than 25.31% of C# online submissions for Valid Parentheses.

public class Solution {
    public bool IsValid(string s) {
        var openingBrackets = new List<char>() { '(', '[', '{', '<' };
        var closingBrackets = new List<char>() { ')', ']', '}', '>' };

        var allMissingBrackets = new List<List<char>>();

        var openedBrackets = new List<char>();
        
        foreach (var bracket in s)
        {
            if (openingBrackets.Contains(bracket))
            {
                openedBrackets.Add(bracket);
            }
            else
            {
                var correspondingOpeningBracket = openingBrackets.ElementAt(closingBrackets.IndexOf(bracket));

                int index = openedBrackets.FindLastIndex(x => x == correspondingOpeningBracket);

                // Closing bracket and no matching opening bracket exists
                if (index == -1)
		{
			return false;
		}
                
                if (index == openedBrackets.Count - 1)
                {
                    Console.WriteLine(index);
                    openedBrackets.RemoveAt(index);
                }
                else
                {
                    break;
                }
            }   
            
        }
        
        // Evaluate if any opened brackets are legt
        if (openedBrackets.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
