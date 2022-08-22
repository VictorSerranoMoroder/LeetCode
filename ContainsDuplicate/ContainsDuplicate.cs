using System;
using System.Collections.Generic;

class ContainsDuplicate
{
    public static void Main() {
        int [] nums = {1,2,3,4,5,1};
        Console.WriteLine(Contains(nums));
    }

    public static bool Contains(int[] nums) {

        for (int i = 0; i < nums.Length; i++)
            for (int j = i+1; j < nums.Length; j++)
                if (j != i)
                    if (nums[i] == nums[j])
                        return true;
        return false;
    }

}