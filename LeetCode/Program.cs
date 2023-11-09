

public class TwoNumbers
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


public class PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        char[] Reverse = x.ToString().ToCharArray();
        Array.Reverse(Reverse);
        return new string(Reverse) == x.ToString();
    }
}

public class RomanToInteger
{
    public int RomanToInt(string s)
    {
        var map = new Dictionary<char, int>();
        map.Add('I', 1);
        map.Add('V', 5);
        map.Add('X', 10);
        map.Add('L', 50);
        map.Add('C', 100);
        map.Add('D', 500);
        map.Add('M', 1000);
        int sum = 0;
        int last = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            // If the current numeral is smaller than the previous numeral, subtract it.
            int current = map[s[i]];
            if (current < last)
            {
                sum -= current;
            }
            else
            {
                sum += current;
            }
            //set last to current to compare
            last = current;
        }
        return sum;
    }

}

