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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        Login logWind = new Login();
        ParkingManager parkingManager = new ParkingManager();
        difpassReg diffPasswords = new difpassReg();
        ConfirmReg confReg = new ConfirmReg();
        string userName, userPhone, userCarNumber, userPassword, userConfPassword;
        public Registration()
        {
            InitializeComponent();
        }

        private void cancelfromregButtonClicked(object sender, RoutedEventArgs e)
        {
            logWind.Show();
            this.Close();
        }

        private void regButtonClicked(object sender, RoutedEventArgs e)
        {
            userName = nameRegTextBox.Text;
            userPhone = phoneRegTextBox.Text;
            userCarNumber = carnumRegTextBox.Text;
            userPassword = passRegTextBox.Password.ToString();
            userConfPassword = passconfRegTextBox.Password.ToString();
            if (userPassword != userConfPassword )
            {
                diffPasswords.Show();
            }
            else
            {
                if (parkingManager.tryRegistrate(userPhone, userName, userCarNumber, userPassword))
                {
                    confReg.Show();
                    this.Close();
                    logWind.Show();
                }
            }
        }
    }
}
