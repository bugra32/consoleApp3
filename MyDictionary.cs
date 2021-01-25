using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T,V>
    {
        V[] value;
        T[] keys;

        public MyDictionary()
        {
            value = new V[0];
            keys = new T[0];

        }

        public void Add(V val, T ke)
        {
            V[] temp_value = value;
            T[] temp_keys = keys;

            keys = new T[keys.Length + 1];
            value = new V[value.Length + 1];

            for (int i = 0; i < temp_keys.Length; i++)
            {
                value[i] = temp_value[i];
                keys[i] = temp_keys[i];
            }
            value[value.Length - 1] = val;
            keys[keys.Length - 1] = ke;

        }

        public int Count
        {
            get { return keys.Length; }
        }

    }
}
