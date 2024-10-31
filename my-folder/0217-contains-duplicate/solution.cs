public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var duplicates = new Dictionary<int, int>(); 

        foreach (var i in nums) {
            if (duplicates.ContainsKey(i)) {
                return true;
            } else {
                duplicates.Add(i, 1);
            }
        }
        return false; 
    }
}
