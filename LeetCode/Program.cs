using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
        }

        //Two sum
        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.
        //You can return the answer in any order.

        public int[] TwoSum(int[] nums, int target)
        {
            //if (nums.Length == 0)
            //{
            //    return null;
            //}
            //else
            //{
            //    int[] array = new int[2] ;
            //    for (int i=0;i<(nums.Length-1);i++)
            //    {
            //        if ((nums[i]+ nums[i+1])==target)
            //        {
            //            array[0] = i;
            //            array[1] = i + 1;
            //            return array;
            //        }
            //    }
            //}
            //return null;
            var complements = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (complements.ContainsKey(nums[i]))
                {
                    return new int[] { complements[nums[i]], i };
                }
                complements[target - nums[i]] = i;
            }
            return new int[] { };
        }

        public bool IsPalindrome(int x)
        {
            int original = x;
            int reverse = 0;
            while (x>0)
            {
                int remaining = x % 10;
                reverse = reverse * 10 + remaining;
                x = x / 10;
            }
            if (reverse==original)
            {
                return true;
            }
            return false;
        }
        ///palindrome 
        ///

        /// Longest suffix 
        /// 
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0 )
            {
                return "";
            }
            return null;
        }
    }
}
