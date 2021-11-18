// Runtime: 56 ms, faster than 58.67% of C# online submissions for Palindrome Number.
// Memory Usage: 33.2 MB, less than 5.18% of C# online submissions for Palindrome Number.

public class Solution {
    public bool IsPalindrome(int x) {
        return x.ToString().SequenceEqual(x.ToString().Reverse());
    }
}
