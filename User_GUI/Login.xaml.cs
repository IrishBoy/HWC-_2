using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SmartParkingApp;

namespace User_GUI
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {


        string userLogin;
        string userPassword;
        Registration regWind = new Registration();
        errorLogin errorLog = new errorLogin();
        ParkingManager parkingManager = new ParkingManager();
        public Login()
        {
            InitializeComponent();
        }

        private void regfromloginButtonClicked(object sender, RoutedEventArgs e)
        {
            regWind.Show();
            this.Close();
        }

        private void exitfromloginButtonClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void loginButtonClicked(object sender, RoutedEventArgs e)
        {
            userLogin = loginUserLogin.Text;
            userPassword = passwordUserLogin.Password.ToString();
            if (parkingManager.tryLogin(userLogin, userPassword))
            {
                userSession loggedUser = new userSession(userLogin);
                loggedUser.Show();
            }
            else
            {
                errorLog.Show();
            }
        }
    }
}
