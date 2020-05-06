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

namespace zooshop.mainwindow
{
    /// <summary>
    /// Логика взаимодействия для mainpage.xaml
    /// </summary>
    public partial class mainpage : Page
    {
        public mainpage()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("вы действительно хотите закрыть приложение?", "закрытие приложения", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            string users;
            string password;
            pet_shopEntities2 entities = new pet_shopEntities2();
            try
            {
                if (logintb.Text == "" || passwordbox.Password == "")
                {
                    MessageBox.Show("Пожалуйста, введите логин и пароль", "Не введены данные", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

                if (passCheck.IsChecked == true)
                {
                    password = passwordtb.Text;
                }
                else
                {
                    password = passwordbox.Password;
                }

                if (logintb.Text == "" || passwordbox.Password == "")
                {
                    MessageBox.Show("Пожалуйста, введите логин и пароль", "Не введены данные", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }
                users = logintb.Text;

                var user = entities.user.AsNoTracking().FirstOrDefault(u => u.email == users && u.password == password);
                var post = entities.user.AsNoTracking().FirstOrDefault(p => p.email == users).worker.post.name;

                //var post = entities.user.AsNoTracking().FirstOrDefault(p => p.email == users);
                if (user == null)
                {
                    MessageBox.Show("Неверно введён логин или пароль", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (post == "продавец-консультант")
                    NavigationService.Navigate(new seller.sellerPage());
                if (post == "вет-мастер")
                    NavigationService.Navigate(new vetMaster.vetMasterPage());
                if (post == "менеджер")
                    NavigationService.Navigate(new manager.ManagerPage());
                if (post == "директор")
                    NavigationService.Navigate(new director.directorPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Позовите администратора. " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void passCheck_Unchecked(object sender, RoutedEventArgs e)
        {

            if (passCheck.IsChecked == true)
            {
                passwordtb.Text = passwordbox.Password;
                passwordbox.Visibility = Visibility.Hidden;
                passwordtb.Visibility = Visibility.Visible;
            }
            else
            {
                passwordbox.Password = passwordtb.Text;
                passwordbox.Visibility = Visibility.Visible;
                passwordtb.Visibility = Visibility.Hidden;
            }
        }

        private void signUp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new registration.registrationPage());
        }

        private void passCheck_Checked(object sender, RoutedEventArgs e)
        {
            if (passCheck.IsChecked == true)
            {
                passwordtb.Text = passwordbox.Password;
                passwordbox.Visibility = Visibility.Hidden;
                passwordtb.Visibility = Visibility.Visible;
            }
            else
            {
                passwordbox.Password = passwordtb.Text;
                passwordbox.Visibility = Visibility.Visible;
                passwordtb.Visibility = Visibility.Hidden;
            }
        }
    }
}
