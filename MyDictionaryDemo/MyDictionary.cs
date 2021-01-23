using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T, K>
    {
        T[] _array;
        T[] _tempArray;
        K[] _value;
        K[] _tempValue;

        public MyDictionary()
        {
            _array = new T[0];
            _value = new K[0];
        }

        public void Add(T item1, K item2)
        {
            _tempArray = _array;
            _tempValue = _value;

            _array = new T[_array.Length + 1];
            _value = new K[_value.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
                _value[i] = _tempValue[i];
            }
            _array[_array.Length - 1] = item1;
            _value[_value.Length - 1] = item2;

            Console.WriteLine(item1 + ".City" + ": " + item2 + " added in My Dictionary whit succesful.");
        }
    }
}
