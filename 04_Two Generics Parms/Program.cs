namespace _04_Two_Generics_Parms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwoGen<int, string> tgObj = new TwoGen<int, string>(7, "generics");

            tgObj.showTypes();

            int v = tgObj.GetObj1;
            Console.WriteLine("value: " + v);

            string str = tgObj.GetObj2;
            Console.WriteLine("value: " + str);
        }
    }
    class TwoGen<T1, T2>
    {
        T1 ob1;
        T2 ob2;

        public TwoGen(T1 o1, T2 o2)
        {
            ob1 = o1;
            ob2 = o2;
        }

        public void showTypes()
        {
            Console.WriteLine("Type of T is " + typeof(T1));
            Console.WriteLine("Type of V is " + typeof(T2));
        }

        public T1 GetObj1
        {
            get { return ob1; }
        }

        public T2 GetObj2
        {
            get { return ob2; }
        }
    }
}