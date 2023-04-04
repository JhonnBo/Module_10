namespace _09_Generic_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XY<int> xy = new XY<int>(10, 20);
            XY<double> xy2 = new XY<double>(88.15, 99.78);

            Console.WriteLine(xy.X + ", " + xy.Y);

            Console.WriteLine(xy2.X + ", " + xy2.Y);
        }
    }
    struct XY<T>
    {
        T x;
        T y;

        public XY(T a, T b)
        {
            x = a;
            y = b;
        }

        public T X
        {
            get { return x; }
            set { x = value; }
        }

        public T Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}