namespace _06_Restrict_On_Base_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClass<int> myIntClass = new MyClass<int>(); // NOT ОК!

            MyClass<ChildClassB> myChildClass = new MyClass<ChildClassB>();  // ОК!

            MyClass<BaseClass> myClass = new MyClass<BaseClass>();
            myClass.AddObj(new ChildClassA("Hello A1"));
            myClass.AddObj(new ChildClassA("Hello A2"));

            myClass.AddObj(new ChildClassA("Hello A3"));
            myClass.AddObj(new ChildClassB("Hello B1"));
            myClass.AddObj(new ChildClassB("Hello B2"));
            myClass.AddObj(new ChildClassB("Hello B3"));

            myClass.ShowAllObj();

        }
    }

    class MyClass<T> where T: BaseClass
    {
        List<T> list = new List<T>();
        public void AddObj(T obj)
        {
            list.Add(obj);
        }
        public void ShowAllObj()
        {
            foreach (var item in list)
            {
                item.ShowInfo();
            }
        }
    }

    abstract class BaseClass
    {
        public string PropA { get; set; }
        public BaseClass(string s)
        {
            PropA = s;
        }
        public abstract void ShowInfo();
    }
    class ChildClassA : BaseClass
    {
        public ChildClassA(string s): base(s) { }
        public override void ShowInfo()
        {
            Console.WriteLine("Child Class A object");
        }
    }
    class ChildClassB : ChildClassA
    {
        public ChildClassB(string s) : base(s) { }
        public override void ShowInfo()
        {
            Console.WriteLine("Child Class B object");
        }
    }
}