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
using Vereshchagina1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace Vereshchagina1
{
    /// <summary>
    /// Interaction logic for EmployeesManagementWindow.xaml
    /// </summary>
    public partial class EmployeesManagementWindow : Window
    {
        private readonly VereshchaginaContext _context;
        private ObservableCollection<User> _employees;

        public EmployeesManagementWindow()
        {
            InitializeComponent();

            _context = new VereshchaginaContext();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            _employees = new ObservableCollection<User>(_context.Users.Include(u => u.Role).Where(u => u.Status == "active").ToList());
            EmployeesGrid.ItemsSource = _employees;
        }

        private void GoAddEmployButton_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeeWindow addEmployeeWindow = new AddEmployeeWindow();
            addEmployeeWindow.Show();
            LoadEmployees();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DeleteEmployButton_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeesGrid.SelectedItem != null)
            {
                var selectedEmployee = EmployeesGrid.SelectedItem as User;

                using (var context = new VereshchaginaContext())
                {
                    var employeeToUpdate = context.Users.FirstOrDefault(u => u.Id == selectedEmployee.Id);
                    if (employeeToUpdate != null)
                    {
                        employeeToUpdate.Status = "неактивен";
                        context.SaveChanges();
                        _employees.Remove(selectedEmployee);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите сотрудника для увольнения");
            }
        }
    }
}
