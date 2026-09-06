public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    Dictionary<int, int> seen = [];

    for (int i = 0; i < nums.Length; i++)
    {
        int needed = target - nums[i];
        if (seen.ContainsKey(needed))
        {
            return [seen[needed], i];
        }
        seen[nums[i]] = i;
    }
    return null;
}
}
