using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace AddressBook
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static MainWindow AppWindow;

        public MainWindow()
        {
            InitializeComponent();
            tbServer.Text = "localhost";
            tbDatabase.Text = "serwerowe";
            tbUID.Text = "root";
            btGetData.IsEnabled = false;
            AppWindow = this;
            btSearch.IsEnabled = false;
            btAdd.IsEnabled = false;
        }

        public MySqlConnection connection;
        string myconnection;
        private void BtConnect_Click(object sender, RoutedEventArgs e)
        {
            if (btConnect.Content.ToString() != "Disconnect")
            {
                myconnection =
                    "SERVER=" + tbServer.Text + ";" +
                    "DATABASE=" + tbDatabase.Text + ";" +
                    "UID=" + tbUID.Text + ";" +
                    "PASSWORD=" + pbPassword.Password + ";" +
                    "SslMode=none" + ";";

                connection = new MySqlConnection(myconnection);

                try
                {
                    connection.Open();
                    btConnect.Content = "Disconnect";
                    lbStatus.Content = "Connected";
                    btGetData.IsEnabled = true;
                    btSearch.IsEnabled = true;
                    btAdd.IsEnabled = true;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "Connection error",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                btConnect.Content = "Connect";
                lbStatus.Content = "No connection";
                btGetData.IsEnabled = false;
                btSearch.IsEnabled = false;
                btAdd.IsEnabled = false;
                connection.Close();
            }
        }

        private void BtGetData_Click(object sender, RoutedEventArgs e)
        {
            MySqlCommand get = new MySqlCommand("SELECT * FROM projekt", connection);
            /*
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            dgContacts.DataContext = dt;
            */
            getData(get);
        }

        public void getData(MySqlCommand command)
        {
            dgContacts.Items.Clear();
            using (var record = command.ExecuteReader())
            {
                while (record.Read())
                {
                    App.Contact contact = new App.Contact();
                    contact.ID = int.Parse(record["id"].ToString());
                    contact.Name = record["name"].ToString();
                    contact.Age = int.Parse(record["age"].ToString());
                    dgContacts.Items.Add(contact);
                }
            }
        }
        
        private void Delete(object sender, RoutedEventArgs e) {
            App.Contact contact = (App.Contact)dgContacts.SelectedItem;
            dgContacts.Items.Remove(contact);
            var name = contact.Name;
            Console.WriteLine(name);
            MySqlCommand delete = new MySqlCommand("DELETE FROM projekt WHERE Name='" + name + "'", connection);
            delete.ExecuteNonQuery();
            MySqlCommand get = new MySqlCommand("SELECT * FROM projekt", connection);
            getData(get);
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            App.Contact contact = (App.Contact)dgContacts.SelectedItem;
            UpdateWindow w = new UpdateWindow(contact);
            w.Show();
        }

        private void BtAdd_Click(object sender, RoutedEventArgs e)
        {
            AddWindow w = new AddWindow();
            w.Show();
        }

        private void BtSearch_Click(object sender, RoutedEventArgs e)
        {
                MySqlCommand select = new MySqlCommand("SELECT ID, Name, Age FROM projekt WHERE Name='" + tbName.Text + "' OR Age='" + tbAge.Text + "'", connection);
                getData(select);
        }
    }
}
