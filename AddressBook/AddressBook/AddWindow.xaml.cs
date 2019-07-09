using MySql.Data.MySqlClient;
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
using System.Windows.Shapes;

namespace AddressBook
{
    /// <summary>
    /// Logika interakcji dla klasy AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        private void BtAdd_Click(object sender, RoutedEventArgs e)
        {
            MySqlCommand insert = new MySqlCommand("INSERT INTO projekt (Name,Age) VALUES ('" + tbName.Text + "','" + tbAge.Text + "')", AddressBook.MainWindow.AppWindow.connection);
            insert.ExecuteNonQuery();
            MySqlCommand get = new MySqlCommand("SELECT * FROM projekt", AddressBook.MainWindow.AppWindow.connection);
            AddressBook.MainWindow.AppWindow.getData(get);
            Close();
        }
    }
}
