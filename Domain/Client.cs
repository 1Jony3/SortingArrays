using Domain.Arrays;

namespace Domain
{
    public class Client
    {

        private ListArrays listArrays = new();

        public Client()
        {
            EnterValue();
            SortArraysByCondition();
            GetArrays();
        }

        //На входе функция получает параметр n - натуральное число. 
        public void EnterValue()
        {
            Console.WriteLine("Enter a natural number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            CreateArrays(n);
        }
        //Необходимо сгенерировать n-массивов, каждый массив имеет случайный размер.        
        private void CreateArrays(int n)
        {
            Random size = new Random();
            int sizeArray = size.Next();
            for (int i = 0; i < n; i++)
            {
                while(CheckList(sizeArray) != true) sizeArray = size.Next();
                listArrays.Add(new Arrays.Array(FillInTheArray(new int[sizeArray]), sizeArray));
            }
        }
        //Заполнить массив случайными числами,
        private int[] FillInTheArray(int[] arr)
        {
            Random element = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = element.Next();
            }
            return arr;
        }
        //Размеры массивов не должны совпадать.
        private bool CheckList(int size)
        {
            if (listArrays.Find(size) == true)
                return true;
            else
                return false;   
        }
        //Массивы с четным порядковым номером отсортировать по возрастанию,
        //с нечетным порядковым номером - по убыванию.
        public void SortArraysByCondition()
        {
            listArrays.Sort();
        }
        public void GetArrays()
        {
            Console.WriteLine(listArrays.GetArrays());
        }
        
    }
}
