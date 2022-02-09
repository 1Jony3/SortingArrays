using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Domain.Arrays
{
    internal class ListArrays
    {
        public List<Array> arrays = new();
        private Sorts sorts = new();
        public void Add(Array array)
        {
            this.arrays.Add(array);
        }
        public bool Find(int size)
        {
            //Значит size можно использовать
            if (this.arrays.Find(item => item.Size == size) == null) 
                return true;
            else return false;
        }
        public void Sort() {
            for (int i = 0; i < this.arrays.Count; i++)
            {
                
                if (i % 2 == 0) sorts.Ascending(this.arrays[i].Massiv);
                else sorts.Descending(this.arrays[i].Massiv);
            } 
        }
        public string GetArrays()
        {
            string strArrays = "";
            for (int i = 0; i < this.arrays.Count; i++)
            {
                strArrays += string.Join(" ", this.arrays[i].Massiv) + "\n";
            }
            return strArrays;
        }
    }
}
