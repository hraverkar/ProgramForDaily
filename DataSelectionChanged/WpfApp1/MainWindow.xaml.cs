using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      string ConnectionString = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = TestDatabase; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
      SqlConnection conn = new SqlConnection(ConnectionString);
      string sql = "Select * from Customers";
      conn.Open();
      SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conn);
      DataTable dataSet = new DataTable("Customers");
      sqlDataAdapter.Fill(dataSet);
      Grid1.ItemsSource = dataSet.DefaultView;
      conn.Close();
    }
    class Human
    {
      public string Fname { get; set; }
      public string Lname { get; set; }

      public Human(string fname, string lname)
      {
        this.Fname = fname;
        this.Lname = lname;
      }
  }

    private void DataGrid_Loaded(object sender, RoutedEventArgs e)
    {
      var list = new List<Human>
      {
        new Human("Harshal", "Raverkar"),
        new Human("Shefali", "Sen"),
        new Human("Vikas", "Sharma"),
        new Human("Vijay", "Raj"),
        new Human("Virat", "Kohli")
      };
      var grid = sender as DataGrid;
      grid.ItemsSource = list;
    }

    private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      var grid = sender as DataGrid;
      var selected = grid.SelectedItems;

      List<string> names = new List<string>();
      foreach(var list in selected )
      {
        var human = list as Human;
        names.Add(human.Fname);
        names.Add(human.Lname);
      }
      this.Title = string.Join(",", names);
    }
  }
}
