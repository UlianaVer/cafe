using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Vereshchagina1.cook;
using Vereshchagina1.waiter;
using Vereshchagina1.Models;
using Microsoft.EntityFrameworkCore;

namespace Vereshchagina1
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
            //if (UsernameTextBox.Text == "admin") {
            //    AdminWindow adminWindow = new AdminWindow();
            //    adminWindow.Show();
            //    this.Close();
            //}
            //else if (UsernameTextBox.Text == "cook")
            //{
            //    CookWindow cookWindow = new CookWindow();
            //    cookWindow.Show();
            //    this.Close();
            //}
            //else
            //{
            //    WaiterWindow waiterWindow = new WaiterWindow();
            //    waiterWindow.Show();
            //    this.Close();
            //}

            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            using (var context = new VereshchaginaContext())
            {
                var user = context.Users.Include(u => u.Role).FirstOrDefault(u => u.Login == username && u.Password == password);
                if (user != null)
                {
                    switch (user.Role.Name)
                    {
                        case "admin":
                            AdminWindow adminWindow = new AdminWindow();
                            adminWindow.Show();
                            this.Close();
                            break;
                        case "waiter":
                            WaiterWindow waiterWindow = new WaiterWindow();
                            waiterWindow.Show();
                            this.Close();
                            break;
                        case "cook":
                            CookWindow cookWindow = new CookWindow();
                            cookWindow.Show();
                            this.Close();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }
    }
}