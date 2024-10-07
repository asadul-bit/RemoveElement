using System.Collections.Generic;

public class Solution
{
    int[] arr = new int[5];
    public int RemoveElement(int[] nums, int val)
    {
        List<int> numbers = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                continue;
            }
            numbers.Add(nums[i]);
        }
        int k = numbers.Count;
        Console.WriteLine(k);

        foreach (int item in numbers)
        {
            Console.WriteLine(item);  
        }
        /*for (int i = 0; i < k; i++)
        {
            Console.Write(numbers[i]);
        }*/
        return k;
    }


    public static void Main(string[] args)
    {
      
    
    int n = int.Parse(Console.ReadLine());

    int[] nums = new int[n];
      
    for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
       
    int val=int.Parse(Console.ReadLine());

    Solution solution = new Solution();
     solution.RemoveElement(nums, val);
    }
}
