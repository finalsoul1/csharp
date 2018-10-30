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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PasswordBox
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void pwd_PasswordChanged(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Password changed");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(pwd.SecurePassword.Length.ToString());
            MessageBox.Show(pwd.Password);
        }
    }
}
