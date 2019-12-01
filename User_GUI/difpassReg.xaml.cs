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
    /// Логика взаимодействия для difpassReg.xaml
    /// </summary>
    public partial class difpassReg : Window
    {
        public difpassReg()
        {
            InitializeComponent();
        }

        private void exitErrorButtonClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
