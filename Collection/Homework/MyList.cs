using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class MyList<T>
    {
        private T[] _values;

        public MyList()
        {
            _values = new T[0];
        }
        public void AddItem(T value)
        {
            Array.Resize(ref _values, _values.Length + 1);
            _values[_values.Length - 1] = value;
        }

        public void RemoveItem()
        {
            Array.Resize(ref _values, _values.Length - 1);
        }
        public void ShowItems()
        {
            foreach (var item in _values)
            {
                Console.WriteLine(item);
            }
        }
        public void UpdateItem(int index, T value)
        {
            if (index<0 || index> _values.Length)
            {
                Console.WriteLine("Error");
                return;
            }

            _values[index] = value;
        }


    }
}
