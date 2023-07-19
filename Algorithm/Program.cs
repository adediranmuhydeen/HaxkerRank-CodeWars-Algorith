

using Algorithm;
using System.Collections;
using System.Globalization;

//Console.WriteLine(Code.GenerateIt("Exam", DateTime.UtcNow));
//Console.WriteLine(DateOnly.FromDateTime(DateTime.UtcNow).ToString());

Dictionary<string, string> myDic = new();

Hashtable myAsh = new();

myDic.Add("Adebayo", "Adediran");

myAsh.Add(3, 'a');
myAsh.Add("orange", "Drink");

foreach(var item in myDic)
{
    Console.WriteLine($"Key is {item.Key} while the value is {item.Value}");
}

Stack stack = new();
stack.Push("Awwal");
stack.Push("Abdulsalam");
stack.Push("Anas");

foreach(var item in stack)
{
    Console.WriteLine(item);
}

Queue queue = new();

queue.Enqueue("Awwal");
queue.Enqueue("Abdulsalam");
queue.Enqueue("Anas");
foreach (var item in queue)
{
    Console.WriteLine(item);
}

Console.WriteLine(CodeWars.CheckAnagram("Adedi", "diAde"));

Console.WriteLine(Code.PrinterError("muhydeen"));
var d = 999999999 + "";
var c = Convert.ToInt32(d);

Console.WriteLine(CodeWars.DigitalRoot(49));

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

int[] myArr = { 0, 0, 0, 0, 0 };

Console.WriteLine(CodeWars.FindEvenIndex(myArr));