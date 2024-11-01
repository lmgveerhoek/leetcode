public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Create a dictionary for all the numbers to count their occurences
        var numDictionary = new Dictionary<int, List<int>>(); 

        // For each number in the array, add the indices to a list
        for (int i = 0; i < nums.Length; i++) {
            if (!numDictionary.ContainsKey(nums[i]))
                numDictionary[nums[i]] = new List<int>(); 

            numDictionary[nums[i]].Add(i);
        }

        // Loop through all the numbers, find the remainder
        // and see if it exists in the array without being the same index. 
        for (int i = 0 ; i < nums.Length; i++) {
            var remainder = target - nums[i]; 
            if (numDictionary.ContainsKey(remainder))
                foreach (var index in numDictionary[remainder])
                    if (index != i)
                        return [i, index];
        }

        return [];
    }
}
