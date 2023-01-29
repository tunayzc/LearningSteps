using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev4
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

        }
    }
}
        
        
  
