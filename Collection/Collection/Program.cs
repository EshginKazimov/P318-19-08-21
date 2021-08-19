using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arraylist, List

            //ArrayList list = new ArrayList();
            //list.Add(10);
            //list.Add("Elnur");
            ////list.Clear();
            //list.Add(true);
            //list.Add(10.5);
            //list.Remove(10.5);
            //list.RemoveAt(0);
            //list[0] = 50;

            //foreach (object item in list)
            //{
            //    //if (item is string text)
            //    //{
            //    //Console.WriteLine(text);
            //    //}
            //    Console.WriteLine(item);
            //}

            //List<int> list = new List<int>();
            //list.Add(5);
            //list.Add(10);
            //list.Add(20);
            //list.Add(4);
            //list.RemoveAt(2);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Hashtable, Dictionary

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add('A', "Rail");
            //hashtable.Add('C', "Fagan");
            //hashtable.Add('B', "Elnur");
            //hashtable.Add('D', "Elnur");

            //Console.WriteLine(hashtable['A']);

            //Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //dictionary.Add(3, "Rail");
            //dictionary.Add(1, "Elnur");
            //dictionary.Add(2, "Fagan");
            //dictionary.Add(4, "Sarkhan");

            ////Console.WriteLine(dictionary[2]);

            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("=============");

            //SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();
            //sortedDictionary.Add(3, "Rail");
            //sortedDictionary.Add(1, "Elnur");
            //sortedDictionary.Add(2, "Fagan");
            //sortedDictionary.Add(4, "Sarkhan");

            //foreach (var item in sortedDictionary)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region LinkedList

            //LinkedList<int> linkedList = new LinkedList<int>();
            //linkedList.AddFirst(10);
            //linkedList.AddAfter()

            #endregion

            #region Queue - FIFO

            //Queue<string> novbe = new Queue<string>();
            //novbe.Enqueue("Elnur");
            //novbe.Enqueue("Rail");
            //novbe.Enqueue("Fagan");
            //novbe.Enqueue("Ulvi");

            //Dequeue(novbe);

            //foreach (var item in novbe)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Stack - LIFO

            //Stack<string> novbe = new Stack<string>();
            //novbe.Push("Elnur");
            //novbe.Push("Rail");
            //novbe.Push("Fagan");
            //novbe.Push("Ulvi");

            //Console.WriteLine("Sira kimdedir? " + novbe.Peek());
            //novbe.Pop();
            //Console.WriteLine("Sira kimdedir? " + novbe.Peek());

            #endregion
        }

        //static void Dequeue(Queue<string> novbe)
        //{
        //    Console.WriteLine("Sira kimdedir? " + novbe.Peek());
        //    novbe.Dequeue();
        //    novbe.Enqueue("Sarkhan");
        //}
    }
}
