public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        // Create a dictionary to store all the anagram groups
        var anagramGroups = new Dictionary<string, List<string>>();
        
        // Loop through all the words 
        foreach (var str in strs) {
            // Sort the characters of the words
            var sortedChars = str.ToCharArray();
            Array.Sort(sortedChars);
            var sortedString = new string(sortedChars);

            // Add the words to the anagram group if it exists or create a new one
            if (!anagramGroups.ContainsKey(sortedString)) {
                anagramGroups[sortedString] = new List<string> { str };
            } else { 
                anagramGroups[sortedString].Add(str);
            }
        }

        // Convert the dictionary to the expected output
        var groupedAnagrams = anagramGroups.Values.Select(list => (IList<string>)list).ToList();

        return groupedAnagrams;
    }
}
