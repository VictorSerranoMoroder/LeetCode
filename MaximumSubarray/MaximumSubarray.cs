using System;
class MaximumSubarray
{  
    public static void Main() {
        int [] nums = {-1,-2,-3,-4};
        
        Console.WriteLine(MaximumSubArray(nums));
    }

    public static int MaximumSubArray(int [] nums) {

        int sum = nums[0], maxSum = nums[0], prefIndex = 0, size = 0;
        if (nums.Length == 1)
            return nums[0];

        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i];
            if (sum < 0) {           
                prefIndex = i+1;
                size = 0;
                sum = 0;
            }
            else {
                size++;
            }

            if (sum > maxSum)
                maxSum = sum;

        }
        
        return maxSum;
    }
}