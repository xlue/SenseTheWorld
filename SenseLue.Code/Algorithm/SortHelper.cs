using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenseLue.Code.Algorithm
{
    public class SortHelper
    {
        /// <summary>
        /// 直接插入排序
        /// 时间复杂度：O（n^2）
        /// </summary>
        /// <param name="nums">将要排序的数组</param>
        /// <param name="type">true：升序 从小到大；false：降序 从大到小</param>
        public static void InsertSort(ref int[] nums, bool type)
        {
            if (type)
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] < nums[i - 1])
                    {
                        int temp = nums[i];
                        int j = 0;
                        for (j = i - 1; j >= 0 && nums[j] > temp; j--)
                        {
                            nums[j + 1] = nums[j];
                        }
                        nums[j + 1] = temp;
                    }
                }
            }
            else
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] > nums[i - 1])
                    {
                        int temp = nums[i];
                        int j = 0;
                        for (j = i - 1; j >= 0 && nums[j] < temp; j--)
                        {
                            nums[j + 1] = nums[j];
                        }
                        nums[j + 1] = temp;
                    }

                }
            }

        }


        /// <summary>
        /// 快速排序法
        /// </summary>
        /// <param name="nums">将要排序的列表</param>
        /// <param name="left">左边的值</param>
        /// <param name="right">右边的值</param>
        public static void QuickSort(ref List<int> nums, int left, int right)
        {
            if (left < right)
            {
                int i = left;
                int j = right - 1;
                int middle = nums[(left + right) / 2];
                while (true)
                {
                    while (i < right && nums[i] < middle) { i++; };
                    while (j > 0 && nums[j] > middle) { j--; };
                    if (i == j) break;
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    if (nums[i] == nums[j]) j--;
                }
                QuickSort(ref nums, left, i);
                QuickSort(ref nums, i + 1, right);
            }
        }
    }
}
