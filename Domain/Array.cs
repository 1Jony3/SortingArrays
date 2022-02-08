using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Array
    {
        public int[] Massiv { get; }
        public int Size { get; }

        public Array(int[] massiv, int size)
        {
            Massiv = massiv;
            Size = size;
        }
    }
}
