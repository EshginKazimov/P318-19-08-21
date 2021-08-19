using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> intList = new MyList<int>();
            intList.AddItem(5);
            intList.AddItem(10);
            intList.AddItem(15);
            intList.ShowItems();
            intList.UpdateItem(0, 55);
            intList.ShowItems();
            intList.UpdateItem(5, 44);
            intList.ShowItems();
            MyList<string> stringList = new MyList<string>();

        }
    }


}
