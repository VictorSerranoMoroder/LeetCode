class TwoSum
{
	public static void Main()
	{
        int [] nums = new int[] {3,2,4};
        int target = 6;
		int [] result = Solution(nums,target);
	}

    private static int[] Solution(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i++) 
            for(int j = 0; j < nums.Length; j++){

                if (j == i)
                    continue;

                if (nums[i] + nums[j] == target)
                    return new int[2] {i,j};
            }
            
        
        return new int[2] {0,0};
    }
}