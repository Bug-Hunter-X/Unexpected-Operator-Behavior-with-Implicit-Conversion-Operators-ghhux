public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(MyClass obj)
    {
        return obj.MyProperty;
    }

    public static implicit operator MyClass(int value)
    {
        return new MyClass(value);
    }

    public static MyClass operator +(MyClass a, int b)
    {
        return new MyClass(a.MyProperty + b);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyClass obj1 = 5; // Implicit conversion from int to MyClass
        int num = obj1;    // Implicit conversion from MyClass to int

        MyClass obj2 = new MyClass(10);
        MyClass sum = obj2 + 5; // Now works correctly
        int result = sum; //Implicit conversion from MyClass to int
    }
}