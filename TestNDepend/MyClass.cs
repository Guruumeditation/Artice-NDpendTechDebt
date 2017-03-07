namespace TestNDepend
{
    public class MyClass
    {
        public bool MyProperty { get; set; }

        public MyClass()
        {
        }

        public MyClass(bool myProperty)
        {
            MyProperty = myProperty;
        }

        public bool Method1(int data)
        {
            if (data % 2 == 0)
                return true;

            return false;
        }

        public void Method2()
        {
            MyProperty = !MyProperty;
        }
    }
}
