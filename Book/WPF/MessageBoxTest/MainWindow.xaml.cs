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

namespace MessageBoxTest
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Yes/No를 선택하세요.", "2버튼 메시지 박스 테스트", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                tb.Text = "2버튼 YES 클릭";
            }
            else
            {
                tb.Text = "2버튼 NO 클릭";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("메시지", "타이틀(Question 메시지박스,YesNoCancel)", 
                MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                tb.Text = "3버튼 YES 클릭";
            }
            else if (result == MessageBoxResult.No)
            {
                tb.Text = "3버튼 NO 클릭";
            }
            else if (result == MessageBoxResult.Cancel)
            {
                tb.Text = "3버튼 CANCEL 클릭";
            }
        }
    }
}
