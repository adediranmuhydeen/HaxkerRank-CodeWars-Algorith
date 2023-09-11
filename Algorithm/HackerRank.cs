namespace Algorithm
{
    public class HackerRank
    {
        public static string CheckPalindrome(string s)
        {
            int count = 0;
            Dictionary<char, int> temp = new();
            for (int i = 0; i < s.Length; i++)
            {
                if (temp.ContainsKey(s[i]))
                {
                    temp[s[i]]++;
                }
                else
                {
                    temp.Add(s[i], 1);
                }
            }
            //foreach (var keyValuePair in temp)
            //{
            //    myList.Add(keyValuePair.Value);
            //}
            //if (myList.Count == 0 || (myList.Count == s.Length))
            //{
            //    return "NO";
            //}
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (myList[i] % 2 != 0)
            //    {
            //        count++;
            //    }
            //}
            return count % 2 == 0 ? "Yes" : "NO";
        }

        /// <summary>
        /// Watson likes to challenge Sherlock's math ability. He will provide a starting and ending value that describe a 
        /// range of integers, inclusive of the endpoints. Sherlock must determine the number of square integers within that range.
        /// Note: A square integer is an integer which is the square of an integer
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int squares(int a, int b)
        {
            int count = 0;
            while (a <= b)
            {
                double c = Math.Sqrt(a);
              if (c - Math.Floor(c) == 0)
                {
                    count++;
                }
                a++;
            }
            return count;
        }
    }
}
