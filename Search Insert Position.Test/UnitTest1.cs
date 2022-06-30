namespace Search_Insert_Position.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 5, 6 }, 5, 2)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 2, 1)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 7, 4)]
        [InlineData(new int[] { }, 7, 0)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 6, 3)]
        public void XUnitTest(int[] nums, int target, int expected)
        {
            Solution solution = new Solution();
            int pos = solution.SearchInsert(nums, target);

            Assert.Equal(expected, pos);
        }
    }
}