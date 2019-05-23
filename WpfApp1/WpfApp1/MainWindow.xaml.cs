using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
  }
}
