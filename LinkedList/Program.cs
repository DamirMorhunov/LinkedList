
using MyDataStructures;


//System.Collections.Generic.LinkedList<string> strings = new();
//strings.

//MyDataStructures.LinkedList<string> list = new();
//ListNode<string> node = new("hello");
//Console.WriteLine(node.Data);
//Console.WriteLine(list.First);
//Console.WriteLine("--------------------------------------------------");
//MyDataStructures.LinkedList<string> persons = new();
//Console.WriteLine(persons.First +"    "+ persons.Last);
//Console.WriteLine(persons.IsEmpty);
//persons.Add("Bob");
//persons.Add("Mike");
//persons.Prepend("Jose");

//Console.WriteLine(persons.Count);
//Console.WriteLine(persons.IsEmpty);
//foreach (var person in persons)
//{
//    Console.WriteLine(person);
//}
//Console.WriteLine("--------------------------------------------------");
//persons.Remove("Mike");
//foreach (var person in persons)
//{
//    Console.WriteLine(person);
//}
//Console.WriteLine(persons.Count);
//Console.WriteLine("--------------------------------------------------");
//persons.Clear();
//persons.Prepend("Mike");
//persons.Prepend("Bob");
//persons.Prepend("Jose");
//persons.Prepend("PEPE");
//foreach (var person in persons)
//{
//    Console.WriteLine(person);
//}
//Console.WriteLine(persons.IsEmpty);//false
//Console.WriteLine(persons.Count);
//Console.WriteLine("--------------------------------------------------");
//Console.WriteLine(persons.Contains("Chupacabra"));//false
//foreach (var person in persons)
//{
//    Console.WriteLine(person);
//}
//Console.WriteLine(persons.Count);

//MyDataStructures.List<string> list = new();
//list.Add("Bob");
//list.Add("Mike");
//list.Add("Jerry");
//foreach (var pers in list)
//{
//    Console.WriteLine(pers);
//}
//Console.WriteLine("----------------------------------------------------------------------------");
//list.Prepend("Jose");
//foreach (var pers in list)
//{
//    Console.WriteLine(pers);
//}
//Console.WriteLine("----------------------------------------------------------------------------");
//list.Remove("Jose");
//foreach (var pers in list)
//{
//    Console.WriteLine(pers);
//}
MyDataStructures.Stack<string> strings = new();
strings.Push("Jean");
strings.Push("Simmon");
strings.Push("Jeb");
foreach (var item in strings)
{
    Console.WriteLine(item);
}
Console.WriteLine("--------------------------------------------------");
Console.WriteLine(strings.Peek());
Console.WriteLine(strings.Pop());
Console.WriteLine(strings.Peek());
Console.WriteLine(strings.Pop());
Console.WriteLine(strings.Peek());
Console.WriteLine(strings.Pop());
Console.WriteLine(strings.Peek());
//Console.WriteLine(strings.Pop());

