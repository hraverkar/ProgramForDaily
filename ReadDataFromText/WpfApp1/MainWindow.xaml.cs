using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;

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
    }
    List<Patient> _list;
    public void DataGrid_Loaded(object sender,RoutedEventArgs e)
    {
      var patients = new List<Patient>();
      using (StreamReader reader = new StreamReader(@"C:\Temp\Data.txt"))
      {
        while(true)
        {
          string line = reader.ReadLine();
          if(line == null)
          { break; }
          patients.Add(new Patient(line));
        }
      }
      this._list = patients;
      var grid = sender as DataGrid;
      grid.ItemsSource = patients;
    }



    private void Window_Closing(object sender, CancelEventArgs e)
    {
      using(StreamWriter writer = new StreamWriter(@"C:\Temp\Data.txt"))
      {
        foreach(Patient patient in this._list)
        {
          writer.WriteLine(patient.GetLine());
        }
      }
    }
  }
}
