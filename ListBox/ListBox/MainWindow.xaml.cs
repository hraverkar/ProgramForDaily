using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListBox
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      List<TodoItems> items = new List<TodoItems>
      {
        new TodoItems() { Name = "C#", Completion = 90 },
        new TodoItems() { Name = "NodeJS", Completion = 70 },
        new TodoItems() { Name = "Angular", Completion = 50 },
        new TodoItems() { Name = "PostgreSQL", Completion = 40 },
        new TodoItems() { Name = "Java", Completion = 30 },
        new TodoItems() { Name = "Luciad Developer", Completion = 20 },
        new TodoItems() { Name = "MSSQL", Completion = 60 },
        new TodoItems() { Name = "Cesium", Completion = 20 },
        new TodoItems() { Name = "C#", Completion = 90 },
        new TodoItems() { Name = "C#", Completion = 90 }
      };

      listbx.ItemsSource = items;
    }
  }
}
