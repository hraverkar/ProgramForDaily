using System.Windows;

namespace WpfApp3
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private readonly Person _person = new Person{ Name="Harshal Raverkar", Age =26};
    public MainWindow()
    {
      InitializeComponent();
      this.DataContext = _person;
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
      var message = _person.Name + " is " + _person.Age;
      MessageBox.Show(message);
    }
  }

  internal class Person
  {
    public string Name { get; set; }

    private int _ageValue;
    public int Age
    {
      get => _ageValue;
      set
      {
        // ReSharper disable once RedundantCheckBeforeAssignment
        if (value != _ageValue)
        {
          _ageValue = value;
        }
      }
    }
  }
}
