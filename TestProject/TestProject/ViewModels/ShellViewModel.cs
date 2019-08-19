using System.Windows;
using Caliburn.Micro;

namespace TestProject.ViewModels
{
  internal class ShellViewModel :PropertyChangedBase
  {
    private string _name;

    public string Name
    {
      get => _name;
      set
      {
        _name = value;
        NotifyOfPropertyChange(()=>Name);
        NotifyOfPropertyChange(()=>CanSayHello);
      }
    }

    public bool CanSayHello => !string.IsNullOrWhiteSpace(Name);

    public void SayHello()
    {
      MessageBox.Show($"Hello {Name}");
      Name = string.Empty;
    }
  }
}
