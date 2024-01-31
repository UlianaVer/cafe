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

namespace Vereshchagina1
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void GoEmployManButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeesManagementWindow employeesManagementWindow = new EmployeesManagementWindow();
            employeesManagementWindow.Show();
        }

        private void GoOrdersButton_Click(object sender, RoutedEventArgs e)
        {
            OrdersWindow ordersWindow = new OrdersWindow();
            ordersWindow.Show();
        }

        private void GoShiftsButton_Click(object sender, RoutedEventArgs e)
        {
            ShiftManagementWindow shiftManagementWindow = new ShiftManagementWindow();
            shiftManagementWindow.Show();
        }
    }
}
