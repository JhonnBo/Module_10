namespace _06_Restrict_On_Base_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClass<int> myIntClass = new MyClass<int>(); // NOT ОК!

            MyClass<ChildClassB> myChildClass = new MyClass<ChildClassB>();  // ОК!

            //MyClass<BaseClass> myClass = new MyClass<BaseClass>(); // нельзя создавать экземпляры абстр.кл.
            myChildClass.AddObj();
            myChildClass.AddObj();
            myChildClass.AddObj();
            myChildClass.AddObj();
            myChildClass.AddObj();

            myChildClass.ShowAllObj();

        }
    }

    class MyClass<T> where T: BaseClass, new()
    {
        static int Counter = 0;
        List<T> list = new List<T>();
        public void AddObj()
        {
            Counter++;
            T obj = new T();
            obj.PropA = "Obj " + Counter;
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
        //public BaseClass(string s)
        //{
        //    PropA = s;
        //}
        public BaseClass() { }
        public abstract void ShowInfo();
    }
    class ChildClassA : BaseClass
    {
        //public ChildClassA(string s): base(s) { }
        public override void ShowInfo()
        {
            Console.WriteLine("Child Class A object " + PropA);
        }
    }
    class ChildClassB : ChildClassA
    {
        //public ChildClassB(string s) : base(s) { }
        public override void ShowInfo()
        {
            Console.WriteLine("Child Class B object " + PropA);
        }
    }
}