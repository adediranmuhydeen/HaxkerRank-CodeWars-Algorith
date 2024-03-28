using System.Globalization;

namespace Algorithm
{
    public class Code
    {
        public static string GenerateIt(string name, DateTime createdDate)
        {
            var _service = new List<string>{"EX2306235678"};
            var ID = name.Substring(0,2).ToUpper() + createdDate.ToString().Substring(0,2) 
                + createdDate.ToString("d").Substring(3, 2) 
                + createdDate.ToString("d").Substring(8, 2) 
                + new Random().Next(1,9999).ToString().PadLeft(4,'0');
            
            if(_service.Contains(ID))
            {
                GenerateIt(name, createdDate);
            }
            return ID;
        }

        public static string PrinterError(String s)
        {

            var sList = new List<char> {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm' };
            var temp = s.Count(x => sList.Contains(x) == false);
            return $"{temp}/{s.Length}";
        }
        /// <summary>
        /// Write a function that take integer month and return the number of days in that month
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        //public static int CheckCalender(int month)
        //{
        //    Calendar calendar = new Calendar();
        //}

        public static int ConvertToAnyBase(int bas, int number)
        {
            List<string> result = new();
            var res = string.Empty;
            while(number > 0)
            {
                var i = number % bas;
                result.Add(Convert.ToString(i));
                number  = number / bas;
            }
            for(int i=result.Count-1; i>=0; i--)
            {
                res += result[i];
            }
            return Convert.ToInt32(res);
        }

        /// <summary>
        /// Sort elements of list of integers in ascending order
        /// </summary>
        /// <param name="list"></param>
        /// <returns>List of int</returns>
        public static List<int> BubbleSort(List<int> list)
        {            
            
            for(int i = 0; i< list.Count ; i++) 
            {
                int myIndex = i+1;
                while (myIndex < list.Count)
                {
                    if (list[myIndex] < list[i])
                    {
                        int place = list[i];
                        list[i] = list[myIndex];
                        list[myIndex] = place;
                    }
                    myIndex++;
                }
            }
            return list;

        }
    }
}
