using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev4
{
    internal class MyDictionary<TKey, TValue>
    {
        KeyValuePair<TKey, TValue>[] items;
        public MyDictionary()
        {
            items = new KeyValuePair<TKey, TValue>[0];
        }
        public void Add(TKey key, TValue value)
        {
            KeyValuePair<TKey, TValue>[] tempArray = items;
            items = new KeyValuePair<TKey, TValue>[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
                
            }
            items[items.Length - 1] = new KeyValuePair<TKey, TValue>(key, value);
            }
        }
    }

        
        
  
