public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        var returnList = new List<int>();
        
        for (int i = 1; i <= nums.Count(); i++)
        {
            if (!nums.Contains(i))
            {
                returnList.Add(i);
            }
        }
        
        return returnList;
    }
}
