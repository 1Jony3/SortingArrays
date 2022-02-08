using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class ListArrays
    {
        List<Array> arrays = new();
        public void Add(Array array)
        {
            arrays.Add(array);
        }
        public bool Find(int size)
        {
            if (arrays.Find(item => item.Size == size) == null) //Значит size можно использовать
                return true;
            else return false;
        }
    }
}
