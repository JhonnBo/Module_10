using System.Diagnostics;

namespace _13_Co_And_CotrVar_in_Delegates
{

    delegate T2 Deleg<in T1, out T2>(T1 d);

    class Program
    {       
        static void Main(string[] args)
        {      

            Deleg<C, A> deleg = Method;

            deleg(new C()).Info();
            //Method(new A()).Info();

        }

        public static C Method(A a)
        {
            a.Info();
            return new C();
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