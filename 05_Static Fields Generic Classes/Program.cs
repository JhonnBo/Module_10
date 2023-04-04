namespace _05_Static_Fields_Generic_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyGeneric<int> obj1 = new MyGeneric<int>();
            obj1.PropVal = 10;
            MyGeneric<int>.Stat_var = 7;
            Console.WriteLine(obj1.PropVal);
            Console.WriteLine("Stat_var = " + MyGeneric<int>.Stat_var);


            MyGeneric<string> obj2 = new MyGeneric<string>();
            obj2.PropVal = "Generic";
            MyGeneric<string>.Stat_var = "Static";
            Console.WriteLine(obj2.PropVal);
            Console.WriteLine("Stat_var = " + MyGeneric<string>.Stat_var);
        }
    }
    class MyGeneric<T>
    {
        static public T Stat_var;
        public T PropVal { get; set; }
    }
}