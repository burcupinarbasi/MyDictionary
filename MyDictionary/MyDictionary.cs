using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K, V>
    {
        K[] _keys;
        V[] _values;

        public MyDictionary()
        {
            _keys = new K[0];
            _values = new V[0];
        }
        public void Add(K key, V value)
        {
           
            K[] TempKeys = _keys;
            V[] TempValues = _values;
            _keys = new K[_keys.Length + 1];
            _values = new V[_values.Length +1];
            for (int i = 0; i < TempKeys.Length; i++)
            {
                _keys[i] = TempKeys[i];
                _values[i] = TempValues[i];

            }
            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;

        }

        public int Count 
        { get { return _keys.Length; } 
        }
    }
        
}
