namespace _13_Co_And_CotrVar_in_Delegates
{
    delegate A Deleg(C d);

    class Program
    {
        public static B Method(A a)
        {
            a.Info();
            return new C();
        }
        static void Main(string[] args)
        {
            Deleg deleg = Method;

            deleg(new C()).Info();
            Method(new A()).Info();
        }

    }

    class A
    {
        public virtual void Info()
        {

            Console.WriteLine("This is A");
        }
    }
    class B:A
    {
        public override void Info()
        {

            Console.WriteLine("This is B");
        }
    }
    class C : B
    {
        public override void Info()
        {

            Console.WriteLine("This is C");
        }
    }
}