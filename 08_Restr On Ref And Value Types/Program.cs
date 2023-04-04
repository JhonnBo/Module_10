namespace _08_Restr_On_Ref_And_Value_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gen<string, int> obj = new Gen<string, int>("generics", 10);
            obj.Print();
            // Ошибка компиляции: первый параметризированный тип должен быть ссылочным
            // Gen<bool, int> obj = new Gen<bool, int>(true, 11); 
        }
    }

    class Gen<T, V>
    where T : class
    where V : struct
    {
        T ob1;
        V ob2;

        public Gen(T t, V v)
        {
            ob1 = t;
            ob2 = v;
        }

        public void Print()
        {
            Console.WriteLine(ob1 + " " + ob2);
        }
    }
}