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
    /// Interaction logic for ShiftManagementWindow.xaml
    /// </summary>
    public partial class ShiftManagementWindow : Window
    {
        public ShiftManagementWindow()
        {
            InitializeComponent();
        }

        private void GoAddShiftButton_Click(object sender, RoutedEventArgs e)
        {
            AddShiftWindow addShiftWindow = new AddShiftWindow();
            addShiftWindow.Show();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
