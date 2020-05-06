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

namespace zooshop.vetMaster
{
    /// <summary>
    /// Логика взаимодействия для vetMasterPage.xaml
    /// </summary>
    public partial class vetMasterPage : Page
    {
        public vetMasterPage()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("вы действительно хотите выйти?", "подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                NavigationService.Navigate(new mainwindow.mainpage());
            }
        }
    }
}
