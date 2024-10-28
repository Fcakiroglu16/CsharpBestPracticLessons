// See https://aka.ms/new-console-template for more information

using System.Collections;

Console.WriteLine("Collections");


//write to sortedlist example





// white to hastable example
Hashtable hashtable = new Hashtable();

hashtable.Add(3, "three");
hashtable.Add(1, "one");
hashtable.Add(2, "two");


foreach (DictionaryEntry item in hashtable)
{

    //write to console
    Console.WriteLine(item.Key + " " + item.Value);
}
Console.WriteLine("------------------");


Dictionary<int,string> dictionary = new Dictionary<int,string>();

dictionary.Add(3, "three");
dictionary.Add(1, "one");
dictionary.Add(2, "two");

//create foreach
foreach (var item in dictionary)
{

    //write to console
    Console.WriteLine(item.Key + " " + item.Value);


}
Console.WriteLine("------------------");
//example sortedDictionary
SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();

sortedDictionary.Add(3, "three");

sortedDictionary.Add(1, "one");

sortedDictionary.Add(2, "two");


foreach (var item in sortedDictionary)
{

    //write to console
    Console.WriteLine(item.Key + " " + item.Value);


}




