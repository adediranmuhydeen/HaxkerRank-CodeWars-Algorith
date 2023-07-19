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
    }
}
