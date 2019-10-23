using System;
/*Call back by Delegate*/
namespace ConsoleApp159
{
  public delegate void TaskCompletedCallBack(string taskResult);
  public class CallBack
  {
    public static void StartNewTask(TaskCompletedCallBack taskCompletedCallBack)
    {
      Console.WriteLine("I have stared the new task");
      taskCompletedCallBack?.Invoke("I have completed task");
    }
  }

  public class CallBackTask {
  public static void Test()
  {
    TaskCompletedCallBack callBack = TestCallBack;
    CallBack testCallBack = new CallBack();
    CallBack.StartNewTask(callBack);
  }

  private static void TestCallBack(string taskResultant)
  {
    Console.WriteLine(taskResultant);
  }
  }

  internal static class Program
  {
    public static void Main(string[] args)
    {
      CallBackTask cbt = new CallBackTask();
      CallBackTask.Test();
    }
  }

}
