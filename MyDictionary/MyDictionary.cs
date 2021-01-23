using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    public class MyDictionary<TKey, TValue>
    {
        TKey[] _arrayKey;
        TKey[] _tempArrayKey;

        TValue[] _arrayValue;
        TValue[] _tempArrayValue;

        public MyDictionary()
        {
            _arrayKey = new TKey[0];
            _arrayValue = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            _tempArrayKey = _arrayKey;
            _tempArrayValue = _arrayValue;

            int arrayLength = _tempArrayKey.Length;

            if (IsKeyControl(key))
            {
                _arrayKey = new TKey[_arrayKey.Length + 1];
                _arrayValue = new TValue[_arrayValue.Length + 1];

                for (int i = 0; i < arrayLength; i++)
                {
                    _arrayKey[i] = _tempArrayKey[i];
                    _arrayValue[i] = _tempArrayValue[i];
                }

                _arrayKey[_arrayKey.Length - 1] = key;
                _arrayValue[_arrayValue.Length - 1] = value;
            }
            else
            {
                Console.WriteLine($"This key data {key} already exists!");
            }

        }

        public int Count
        {
            get { return _arrayValue.Length; }
        }

        public void GetDictionary()
        {
            for (int i = 0; i < _arrayKey.Length; i++)
            {
                Console.WriteLine($"{_arrayKey[i]} - {_arrayValue[i]}");

            }
        }

        public bool IsKeyControl(TKey key)
        {
            for (int i = 0; i < _arrayKey.Length; i++)
            {
                if (_arrayKey[i].Equals(key))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
