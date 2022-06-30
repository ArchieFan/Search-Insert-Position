public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int index = Array.FindIndex(nums, item => item >= target);
        if (index < 0) return nums.Length;
        return index;
    }

    static void Main()
    {
        //int[] nums = { 1, 3, 5, 6 };
        //int target = 5;

        //int[] nums = { 1, 3, 5, 6 };
        //int target = 2;

        //int[] nums = { 1, 3, 5, 6 };
        //int target = 7;

        //int[] nums = { };
        //int target = 7;

        int[] nums = { 1, 3, 5, 6 };
        int target = 6;

        Solution solution = new Solution();
        int pos = solution.SearchInsert(nums, target);

        Console.ReadLine();
    }
}