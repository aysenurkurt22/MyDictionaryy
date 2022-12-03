using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryy
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> faceShapes = new List<string>();
            faceShapes.Add("long");
            faceShapes.Add("oval");
            faceShapes.Add("square");
            Console.WriteLine(faceShapes.Count);



            MyList<string> cities = new MyList<string>();
            cities.Add("Antalya");
            cities.Add("İzmir");
            cities.Add("Muğla");
            cities.Add("Adana");
            Console.WriteLine(cities.Count);
            Console.ReadKey();

        }

    }

    class MyList<T>//Generic class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];//eleman sayısını bir artırdık
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;

        }
        public int Count
        {
            get { return _array.Length; }
        }

    }
}
