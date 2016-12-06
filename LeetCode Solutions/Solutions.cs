using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solutions
{
    public class Solutions
    {
        public int SingleNumber(int[] nums)
        {
            int ret = int.MinValue;

           Hashtable hashedNums = new Hashtable();

            foreach (int num in nums)
            {
                if (hashedNums.ContainsKey(num) == false)
                {
                    hashedNums.Add(num, 0);
                }

                hashedNums[num] = (int)hashedNums[num] + 1;
            }

            foreach (DictionaryEntry de in hashedNums)
            {
                if ((int)de.Value == 1)
                    ret = (int)de.Key;
            }

            if (ret == int.MinValue)
                throw new ArgumentException("Array does not contain a single number");
            
            return ret;
        }

        public bool CanWinNim(int n)
        {
            if ((n % 4) == 0)
                return false;
            else
                return true;
        }

        public int Searc(int[] nums, int target)
        {
            QuickSort(nums, 0, nums.Length - 1);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }

        public void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    QuickSort(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSort(arr, pivot + 1, right);
            }
        }

        public int Partition (int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;

                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }



        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == q)
                return true;

            if (p == null || q == null)
                return false;

            return p.val == q.val &&
                IsSameTree(p.left, q.left) &&
                IsSameTree(p.right, q.right);
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
       }
    }
}
