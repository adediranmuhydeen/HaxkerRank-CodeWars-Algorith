namespace Algorithm
{
    public class CodeWars
    {
        public static bool CheckAnagram(string first, string second)
        {
            var firstArr = first.ToCharArray();
            var secondArr = second.ToCharArray();
            Array.Sort(firstArr);
            Array.Sort(secondArr);
            for(int i=0; i<first.Length; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static int DigitalRoot(long n)
        {
            int result = 0;
            var temp = n.ToString().ToCharArray();
            foreach (var item in temp)
            {
                result += (int)Char.GetNumericValue(item);
            }

            return result;
        }
        /// <summary>
        /// You are going to be given an array of integers. Your job is to take that array and find an index N where the sum
        /// of the integers to the left of N is equal to the sum of the integers to the right of N. If there is no index that
        /// would make this happen, return -1.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int FindEvenIndex(int[] arr)
        {
            int result = -1;
            
            for (int i = 0; i < arr.Length; i++)
            {
                int leftIndex = 0;
                int rightIndex = arr.Length - 1;
                int right = 0;
                int left = 0;
                while (leftIndex < i)
                {
                    left += arr[leftIndex];                    
                    leftIndex++;
                }
                while (rightIndex > i)
                {
                    right += arr[rightIndex];
                    rightIndex--;
                }
                if (left == right)
                {
                    return i;
                }
            }
            return result;
        }
    }
}
