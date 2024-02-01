using System;
using System.Collections.Generic;
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

namespace practic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection connection;
        public MainWindow()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=practic;Integrated Security=SSPI;");
            connection.Open();

            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
      

            if (login.Text.Length > 0)
            {
                if (password.Text.Length > 0)
                {
                    if (login.Text == @"Login" && password.Text == @"Password")
                    {
                        User user1 = new User();
                        user1.Show();
                        this.Close();
                    }
                }
                else MessageBox.Show("Введите пароль");
            }
            else MessageBox.Show("Введите данные");
        }
    }
}
