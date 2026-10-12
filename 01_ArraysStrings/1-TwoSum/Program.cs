public class Solution
{
    public int[] TwoSum(int[] nums, int target) //[2,7,11,15]
    {

        for (int a = 0; a < nums.Length; a++)
        {
            for (int b = 0; b < nums.Length; b++)
            {

                if (a != b && nums[a] + nums[b] == target)
                {

                    return new int[] { a, b };


                }
            }
        }
        int[] empty = new int[0];
        return empty;
    }
}