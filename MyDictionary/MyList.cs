using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyList<K,V>
    {
        K[] _Key;
        K[] tempArray;

        V[] _Value;
        V[] tempArray2;

        public MyList()
        {
            _Key = new K[0];
            _Value = new V[0];
        }
        
        public void Add(K items,V items2)
        {
            tempArray2 = _Value;
            tempArray = _Key;

            _Key = new K[_Key.Length + 1];
            _Value = new V[_Value.Length + 1];

            for (int i = 0; i < tempArray.Length ; i++)
            {
                _Key[i] = tempArray[i];
            }
            _Key[_Key.Length - 1] = items;

            for (int i = 0; i < tempArray2.Length; i++)
            {
                _Value[i] = tempArray2[i];
            }
            _Value[_Value.Length - 1] = items2;
        }

        public void print()
        {
            for (int i = 0; i < _Key.Length ; i++)
            {
                Console.WriteLine("Id : " + _Key[i]);
                Console.WriteLine("Kişi : " + _Value[i]);
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            } 

        }
       
        private int _count;

        public int MyProperty
        {
            get { return _count; }
        }

    }
    
}
