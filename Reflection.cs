using System;
using System.Reflection;

public class MyClass
{
  public virtual int Add(int num1, int num2)
  {
    return num1 + num2;
  }

  public virtual int Subsract(int num1,int num2)
  {
    return num1 - num2;
  }

  public static void Main()
  {
    MyClass myClass = new MyClass();

    Type type = myClass.GetType();

    MethodInfo methodInfo = type.GetMethod("Subsract");
    Console.WriteLine("nType information " + type.FullName);
    Console.WriteLine("nMethod info" +methodInfo.Name);
    Console.ReadLine();
  }

}
