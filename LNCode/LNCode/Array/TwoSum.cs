using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNCode.Array
{
    internal class TwoSum
    {
        public int[] TwoSumProblem(int[] nums, int target)
        {
            //Create a dictionary to store the difference and index
            Dictionary<int, int> map = new Dictionary<int, int>();

            //Iterate through the array
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                //check if complement exists in the map
                if (map.ContainsKey(complement))
                {
                    //If found, return the indices
                    return new int[] { map[complement], i };
                }
                //Add the current number and it's index to the map
                if (!map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = i;
                }
            }
            //If no solution is found, throw an exception
            throw new ArgumentException("No two sum solution");
        }
    }
    
}
