using System;

namespace Open_Lab_04._12
{
    public class Numbers
    {
        public int MissingNum(int[] nums)
        {
            int sventek = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sventek = sventek + nums[i];
            }
            return 55 - sventek;
        }
    }
}
