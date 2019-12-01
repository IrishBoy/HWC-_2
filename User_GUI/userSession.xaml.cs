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

namespace User_GUI
{
    /// <summary>
    /// Логика взаимодействия для userSession.xaml
    /// </summary>
    public partial class userSession : Window
    {
        ParkingManager parkingManager = new ParkingManager();
        public userSession(string userLogin)
        {
            InitializeComponent();
            string carNumber = parkingManager.GetCarNumberByPhone(userLogin);
            List<ParkingSession> _pastSessions = parkingManager.GetSessionsByUser(carNumber);
            userspastSessions.ItemsSource = _pastSessions;
            if (parkingManager.CheckActivSessionByUser(userLogin))
            {
                string _activSessions = "No activ sessions";
                useractivSessions.Text = _activSessions;
            }
            else
            {
                DateTime _entrDate = parkingManager.GetActivSessionByUser(userLogin);
                var currentDt = DateTime.Now;
                var diff = (currentDt - _entrDate).TotalMinutes;
                decimal _curCost = parkingManager.GetCost(diff);
                string _activSessions = String.Format("Enter date {0}, current bill{1}", _entrDate, _curCost);
                useractivSessions.Text = _activSessions;
            }
        }
    }
}
