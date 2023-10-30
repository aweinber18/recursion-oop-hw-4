// See https://aka.ms/new-console-template for more information

/*Link<string> first = new Link<string>("A");

first.Add("B");
first.Add("C");
first.Add("D");
first.Add("E");
first.Add("F");

Console.WriteLine(first.ToString());*/
/*
int[] array = { 21, 35, 65, 12, 24, 58, 7, 83, 49, 51, 27, 46, 50, 99, 93, 73, 14, 20, 39 };
Node<int> head = Node<int>.ArrayToTree(array);
TreePrinter<int>.PrintTree(head, array.Length);
Console.WriteLine(head.Size());*/
/*int[] array = { 21, 35, 65, 12, 24, 58, 7, 83, 49, 51, 27, 46, 50, 99, 93, 73, 14, 20, 39 };
Node<int> head = Node<int>.ArrayToTree(array);
Console.WriteLine(head.Search(25));*/

/*CLinkedList<int> cLinkedList = new CLinkedList<int>();
cLinkedList.Add(0);
cLinkedList.Add(1);
cLinkedList.Add(2);
cLinkedList.Add(3);
cLinkedList.Add(4);
cLinkedList.Add(5);
cLinkedList.Add(6);
cLinkedList.Add(7);
cLinkedList.Add(8);
Console.WriteLine(cLinkedList.Size());*/

int[] ints = { 21, 32, 58, 76, 12, 16, 11, 91 };
int[] sortedInts = ShellSorter<int>.Sort(ints, ints.Length / 2);
foreach (int i in sortedInts) Console.Write(i + ", ");