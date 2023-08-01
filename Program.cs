Console.WriteLine("=========================================");
//! Iterate and print values
static void PrintList(List<string> MyList)
{
    foreach (string item in MyList)
    {
        Console.WriteLine(item);
    }
}
List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
PrintList(TestStringList);


// >>OR<<
Console.WriteLine(" >>>>> OR <<<<<< ");

static void PrintList2(List<string> MyList2)
{
for (int i = 0; i < MyList2.Count; i++)
{
    Console.WriteLine(MyList2[i]);
}
}
List<string> TestStringList2 = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
PrintList(TestStringList2);

Console.WriteLine("=========================================");
//! Print Sum
static void SumOfNumbers(List<int> IntList)
{
int sum = 0;
for (int i = 0; i < IntList.Count; i++)
{
    sum += IntList[i];
}
    Console.WriteLine($"The sum of the numbers in the list is: " + sum);
}
List<int> TestIntList = new List<int>() {2,7,12,9,3};
// You should get back 33 in this example
SumOfNumbers(TestIntList);


Console.WriteLine("=========================================");
//! Find Max
static int FindMax(List<int> IntList)
{
    int max = IntList.Max();
    Console.WriteLine($"The max number is: " + max);
    return max;
}
List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
// You should get back 17 in this example
FindMax(TestIntList2);



Console.WriteLine("=========================================");
//! Square the Values
static List<int> SquareValues(List<int> IntList)
{
    List<int> squaredList = new List<int>();
    foreach (int num in IntList)
    {
        squaredList.Add(num * num);
    }
    return squaredList;
}
List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
List<int> squaredList = SquareValues(TestIntList3);

Console.WriteLine("The numbers squared: ");
Console.WriteLine(string.Join(", ", squaredList));

// You should get back [1,4,9,16,25], think about how you will show that this worked
SquareValues(TestIntList3);



Console.WriteLine("=========================================");
//! Replace Negative Numbers with 0
static int[] NonNegatives(int[] IntArray)
{
    for (int i = 0; i < IntArray.Length; i++)
    {
        if (IntArray[i] < 0)
        {
            IntArray[i] = 0; 
        }
    }
    Console.WriteLine("Updated Array: " + string.Join(", ", IntArray));
    return IntArray;
}
int[] TestIntArray = new int[] {-1,2,3,-4,5};
// You should get back [0,2,3,0,5], think about how you will show that this worked
NonNegatives(TestIntArray);



Console.WriteLine("=========================================");
//! Print Dictionary
static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    foreach (var KeyValuePair in MyDictionary)
    {
        Console.WriteLine($"{KeyValuePair.Key}, {KeyValuePair.Value}");
    }
}
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);



Console.WriteLine("=========================================");
//! Find Key
// static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
// {
//     // Your code here
// }
// // Use the TestDict from the earlier example or make your own
// // This should print true
// Console.WriteLine(FindKey(TestDict, "RealName"));
// // This should print false
// Console.WriteLine(FindKey(TestDict, "Name"));



Console.WriteLine("=========================================");
//! Generate a Dictionary
// // Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// // {
// //	"Julie": 6,
// //	"Harold": 12,
// //	"James": 7,
// //	"Monica": 10
// // } 
// static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
// {
//     // Your code here
// }
// // We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// // Your test code here






