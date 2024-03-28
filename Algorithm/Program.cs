

//using Algorithm;
//using System.Collections;
//using System.Globalization;

//Console.WriteLine(Code.GenerateIt("Exam", DateTime.UtcNow));
//Console.WriteLine(DateOnly.FromDateTime(DateTime.UtcNow).ToString());

//Dictionary<string, string> myDic = new();

//Hashtable myAsh = new();

//myDic.Add("Adebayo", "Adediran");

//myAsh.Add(3, 'a');
//myAsh.Add("orange", "Drink");

//foreach (var item in myDic)
//{
//    Console.WriteLine($"Key is {item.Key} while the value is {item.Value}");
//}

//Stack stack = new();
//stack.Push("Awwal");
//stack.Push("Abdulsalam");
//stack.Push("Anas");
//Console.WriteLine("This is the Stack output\n----------------------------------");
//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}

//Queue queue = new();
//queue.Enqueue("Awwal");
//queue.Enqueue("Abdulsalam");
//queue.Enqueue("Anas");
//Console.WriteLine("This is the Queue output\n----------------------------------");
//foreach (var item in queue)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(Code.PrinterError("muhydeen"));
//var d = 999999999 + "";
//var c = Convert.ToInt32(d);

//Console.WriteLine(CodeWars.DigitalRoot(49));

//string s = "aabbccddeetyjdgcgdyuciebvcjfnocisdanojikmbvbczghhhvnfo mdicdcndoceimdx0eixd0mweidweuch";
//List<int> myList = new();
//Dictionary<char, int> temp = new();
//for (int i = 0; i < s.Length; i++)
//{
//    if (temp.ContainsKey(s[i]))
//    {
//        temp[s[i]]++;
//    }
//    else
//    {
//        temp.Add(s[i], 1);
//    }
//}
//foreach (var keyValuePair in temp)
//{
//    //myList.Add(keyValuePair.Value);
//    Console.WriteLine($" The value for key {keyValuePair.Key} is {keyValuePair.Value}");
//}

//Console.WriteLine(HackerRank.CheckPalindrome("aaddeebb"));

//int[] myArr = { 2, 5, 1, 5, 8 };

//Console.WriteLine(CodeWars.FindEvenIndex(myArr));

//Console.WriteLine(HackerRank.squares(1, 10));
//Console.WriteLine($"First {CodeWars.CheckAnagram("Adedi", "diAde")}");
//Console.WriteLine($"Second {CodeWars.CheckAnagram2("Adedi", "diAde")}");

//Console.WriteLine("--------Convert to Any base");
//Console.WriteLine(Code.ConvertToAnyBase(2, 4));
//Console.WriteLine("\n--------Convert to Any base----------------");

//var temp = EnumToStrigConverter.GetEnumString();

//foreach (var item in temp)
//{
//    Console.WriteLine(item, "\r");
//}

//foreach (var item in Enum.GetValues(typeof(TestEnum)))
//{
//    Console.WriteLine(item);
//}


//Console.WriteLine(EnumToStrigConverter.GetDescription<TestEnum>(TestEnum.EveryDay));

using Algorithm;

List<int> myList =new List<int> { 4, 2 , 5, 10, 23, 1, 3 };

Console.WriteLine("-------bubble sort ------------");
var response = Code.BubbleSort(myList);
foreach (int item in response)
{
    Console.WriteLine(item);
}