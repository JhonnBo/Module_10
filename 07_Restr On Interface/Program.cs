using static System.Net.Mime.MediaTypeNames;
using System.Collections;

namespace _07_Restr_On_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayList list = new ArrayList();
                list.Add("constraints");
                list.Add("on");
                list.Add("interface");
                MyIterator<ArrayList> obj = new MyIterator<ArrayList>(list);
                obj.Print();
                Console.WriteLine();

                string[] arr = new string[] { "constraints", "on", "interface" };
                MyIterator<string[]> obj2 = new MyIterator<string[]>(arr);
                obj2.Print();
                Console.WriteLine();

                Test test = new Test("constraints", "on", "interface");
                MyIterator<Test> obj3 = new MyIterator<Test>(test);
                obj3.Print();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
    class MyIterator<T> where T : IEnumerable
    {
        T collection;

        public MyIterator(T collection)
        {
            this.collection = collection;
        }
        public void Print()
        {
            foreach (object obj in collection)
            {
                Console.Write(obj + " ");
            }
        }
    }

    class Test : IEnumerable // Убрав наследование на интерфейс мы получим ошибку в Main
    {
        string[] arr = null;
        public Test(params string[] arr)
        {
            this.arr = arr;
        }
        public IEnumerator GetEnumerator()
        {
            foreach (string i in arr)
            {
                yield return i;
            }
        }
    }
}