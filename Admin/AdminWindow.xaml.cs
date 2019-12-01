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
using SmartParkingApp.Models;

namespace Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {

        ParkingManager parkingManager = new ParkingManager();
        public AdminWindow()
        {
            InitializeComponent();
            List<ParkingSession> _pastSessions = parkingManager.GetPastSessions();
            pastSessions.ItemsSource = _pastSessions;
            List<ParkingSession> _activSessions = parkingManager.GetActivSessions();
            activSessions.ItemsSource = _activSessions;
            double _placesLeft = parkingManager.GetPlacesLeftPercentage();
            string _left = String.Format("Places left: {0}%", _placesLeft);
            freePlacesPercentage.Text = _left;
        }
    }
}
