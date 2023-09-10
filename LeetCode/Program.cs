Solution test = new();



int[] myNum = { 3, 4, 2 };


int[] result = test.TwoSum(myNum, 6);
string numArray = String.Join(",", result);
Console.WriteLine($"[{numArray}]");

//public class Solution
//{
//    public int[] TwoSum(int[] nums, int target)
//    {
//        for (int i = 0; i < nums.Length - 1; i++)
//            for (int j = i + 1; j < nums.Length; j++)
//                if (nums[i] + nums[j] == target)
//                    return new int[] { i, j };



//        return new int[] { };
//    }
//}



public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int cur = nums[i];
            //cur + x = target
            //x = target - cur
            int x = target - cur;
            if (map.ContainsKey(x))           
                return new int[] { map[x], i };
            else
                map.TryAdd(nums[i], i);
        }
        return default;
    }
}


