public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var duplicates = new Dictionary<int, int>(); 

        foreach (var num in nums) {
            if (duplicates.ContainsKey(num)) {
                return true;
            } else {
                duplicates.Add(num, 1);
            }
        }
        return false; 
    }
}
