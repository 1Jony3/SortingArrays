using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Sorts
    {
        //По возрастанию
        public void Ascending(int[] array)
        {
            Ascending(array, 0, array.Length - 1);
        }
        void Ascending(int[] mas, int first, int last)
        {
            int mid, count;
            int f = first, l = last;
            mid = mas[(f + l) / 2]; 
            do
            {
                while (mas[f] < mid)
                    f++;
                while (mas[l] > mid)
                    l--;
                if (f <= l)
                {
                    count = mas[f];
                    mas[f] = mas[l];
                    mas[l] = count;
                    f++;
                    l--;
                }
            } while (f < l);
            if (first < l)
                Ascending(mas, first, l);
            if (f < last)
                Ascending(mas, f, last);
        }
        //По убыванию
        public void Descending(int[] array)
        {
            Descending(array, 0, array.Length - 1);
        }
        void Descending(int[] mas, int first, int last)
        {
            int mid, count;
            int f = first, l = last;
            mid = mas[(f + l) / 2];
            do
            {
                while (mas[f] > mid)
                    f++;
                while (mas[l] < mid)
                    l--;
                if (f <= l)
                {
                    count = mas[f];
                    mas[f] = mas[l];
                    mas[l] = count;
                    f++;
                    l--;
                }
            } while (f < l);
            if (first < l)
                Descending(mas, first, l);
            if (f < last)
                Descending(mas, f, last);
        }
    }
}
