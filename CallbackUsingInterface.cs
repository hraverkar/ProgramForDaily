using System;
/*Call back by interface*/
namespace ConsoleApp159
{
  public interface IMeeting
  {
    void ShowAgenda(string agenda);
    void EmployeeAttendMeeting(string employee);
    void EmployeeLeftMeeting(string employee);

  }

  public class Meeting : IMeeting
  {
    public void ShowAgenda(string agenda)
    {
     Console.WriteLine("Agenda Details :: " + agenda);
    }

    public void EmployeeAttendMeeting(string employee)
    {
      Console.Out.WriteLine("Employee attend meeting :: "+employee);
    }

    public void EmployeeLeftMeeting(string employee)
    {
      Console.Out.WriteLine("Employee left meeting :: " + employee);
    }
  }

  public class MeetingRoom
  {
    private string message;

    public MeetingRoom(string message)
    {
      this.message = message;
    }

    public void StartMeeting(IMeeting meeting)
    {
      if (meeting !=null)
      {
        meeting.ShowAgenda(message);
      }
    }
  }

  public class MeetingExecution
  {
    public void PerformMeeting()
    {
      IMeeting meeting = new Meeting();
      MeetingRoom meetingRoom = new MeetingRoom("Code Quality Improvement ");
      meetingRoom.StartMeeting(meeting);
    }
  }

  public class Program
  {
    public static void Main(string[] args)
    {
      MeetingExecution me = new MeetingExecution();
      me.PerformMeeting();
    }
  }
}
