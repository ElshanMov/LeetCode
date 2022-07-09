// See https://aka.ms/new-console-template for more information
public class Solution
{
    public static void Main()
    {
        int result = LengthOfLongestSubstring("abcabcbb");
        Console.WriteLine(result);
    }
    /// <summary>
    /// Given a string s, find the length of the longest substring without repeating characters.
    /// </summary>
    /// <param name="s"></param>
    /// <returns>non-repeating char count</returns>
    public static int LengthOfLongestSubstring(string s)
    {
        int count = 1;
        int result=0;
        int stringLength = s.Length;
        if (string.IsNullOrWhiteSpace(s))
        {
            return 0;
        }
        for (int i = 0; i < stringLength; i++)
        {
            if (i == stringLength-1)
            {
                break;
            }
            if (s[i] != s[i + 1])
            {
                count++;
            }
            else
            {
                count=1;
            }
            
            //for (int j = i+1; j < stringLength; j++)
            //{
            //    if (s[i]==s[j])
            //    {
            //        count=0;
            //        flag = false;
            //        break;
            //    }
            //}
            //if (flag)
            //{
            //    count++;

            //}
        }
        return result;
    }
}
