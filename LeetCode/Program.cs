string s = "MCMXCIV";

//Console.WriteLine(s);

int value = 0;
int i = 0;
//Console.WriteLine(s.Length);


while (i < s.Length)
{
    if (i < s.Length - 1)
    {
        Console.WriteLine(i);
        //check if in dictonary
        Console.WriteLine($"{s[i]} {s[i+1]}");
        i += 2;
        continue;
    }
    //Console.WriteLine(s[i]);
    else
        Console.WriteLine(s[i]);
    i++;
}


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

}

