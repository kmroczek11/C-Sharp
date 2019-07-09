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
    /// Logika interakcji dla klasy UpdateWindow.xaml
    /// </summary>
    public partial class UpdateWindow : Window
    {
        App.Contact currentContact;
        public UpdateWindow(App.Contact contact)
        {
            InitializeComponent();
            currentContact = contact;
        }

        private void BtUpdate_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Name " + currentContact.Name + " i age " + currentContact.Age);
            MySqlCommand update = new MySqlCommand("UPDATE projekt SET Name='" + tbName.Text + "', Age='" + tbAge.Text +
            "' WHERE Name='" + currentContact.Name + "'", AddressBook.MainWindow.AppWindow.connection);
            update.ExecuteNonQuery();
            MySqlCommand get = new MySqlCommand("SELECT * FROM projekt", AddressBook.MainWindow.AppWindow.connection);
            AddressBook.MainWindow.AppWindow.getData(get);
            Close();
        }
    }
}
