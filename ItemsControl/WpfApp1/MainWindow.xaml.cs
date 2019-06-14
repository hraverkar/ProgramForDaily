using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp1
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      List<TodoItem> items = new List<TodoItem>
      {
        new TodoItem() { Title = "Harshal Raverkar", Completion = 50 },
        new TodoItem() { Title = "Rajesh Raverkar", Completion = 40 },
        new TodoItem() { Title = "Tsting", Completion = 20 }
      };

      icTodoList.ItemsSource = items;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      txt.Text = "Hello Harshal Raverkar";
    }

   
  }
}
