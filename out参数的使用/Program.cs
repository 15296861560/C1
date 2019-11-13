using System;

namespace out参数的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法，要求要有多个返回值
            //当返回多个相同类型的值的时候可以放到一个数组里面返回
            //如果返回多个不同类型的值的时候就可以考虑使用out

            int[] nums = { 1, 2, 3, 5, 5, 6 };

            int[] res = GetMaxMinSumAvg(nums);
            Console.WriteLine("最大值是{0}，最小值是{1}，总和是{2}，平均值是{3}",res[0], res[1], res[2], res[3]);

            int sum;
            double avg ; 
            GetSumAvg(nums, out sum, out avg);
            Console.WriteLine("总和是{0}，平均值是{1}", sum,avg);
        }

        /// <summary>
        /// 求一个数组的最大值，最小值，总和，平均值
        /// </summary>
        /// <param name="nums">所求数组</param>
        /// <returns>包含所求数组最大值，最小值，总和，平均值的数组</returns>
        public static int[] GetMaxMinSumAvg(int[] nums)
        {
            int[] res = new int[4];
            //假设res[0]为最大值，res[1]为最小值，res[2]为总和，res[3]为平均值

            res[0] = nums[0];//max
            res[1] = nums[0];//min
            res[2] = 0;//总和

            for (int i = 0; i< nums.Length;i++)
            {
                //如果当前元素大于我假定的最大值
                if (nums[i] > res[0])
                {
                    //将当前元素赋值给假定最大值
                    res[0] = nums[i];
                }
                //如果当前元素小于我假定的最小值
                if (nums[i] < res[1])
                {
                    //将当前元素赋值给假定最小值
                    res[1] = nums[i];
                }
                //求总和
                res[2] += nums[i];
            }
            //求平均值
            res[3] = res[2] / nums.Length;
            return res;
        }

        /// <summary>
        /// 计算一个数组的总和和平均值
        /// </summary>
        /// <param name="nums">所求数组</param>
        /// <param name="sum">多余返回的总和</param>
        /// <param name="avg">多余返回的平均值</param>
        public static void GetSumAvg(int[] nums,out int sum,out double avg)
        {
            //out参数要求在方法的内部必须为其赋值
            sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            avg = (double)sum / nums.Length;

        }
    }
}
