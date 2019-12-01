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

namespace User_GUI
{
    /// <summary>
    /// Логика взаимодействия для ConfirmReg.xaml
    /// </summary>
    public partial class ConfirmReg : Window
    {

        Login _usLogin = new Login();
        public ConfirmReg()
        {
            InitializeComponent();
        }

        public void regCompButtonClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
            _usLogin.Show();
        }
    }
}
