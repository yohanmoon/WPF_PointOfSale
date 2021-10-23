
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Threading; //Timer
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_POS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            HomeButton.Focus(); //To make home button highlight when loaded, since home page is loaded
            Display_Date(); //to start the datetime
        }

        

        #region NAVATE TO DIFF PAGE
        private void Navigate_HomePage(object sender, RoutedEventArgs e)
        {
            _Navigation.Content = new View.Home();

        }

        private void Navigate_DropOffPage(object sender, RoutedEventArgs e)
        {
            _Navigation.Content = new View.DropOff();
        }

        private void Navigate_PickUpPage(object sender, RoutedEventArgs e)
        {
            _Navigation.Content = new View.PickUp();
        }

        private void Navigate_CustomerPage(object sender, RoutedEventArgs e)
        {
            _Navigation.Content = new View.Customer();
        }

        private void Navigate_ReportPage(object sender, RoutedEventArgs e)
        {
            _Navigation.Content = new View.Report();
        }
        #endregion


        #region EVENT HANDLER
        private void exitButton_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Do you want to close?", "CLOSE", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.OK)
            {
                Application.Current.Shutdown();
            }


        }

        private void fullscreenButton_Click(object sender, RoutedEventArgs e)
        {
            switch (Application.Current.MainWindow.WindowState)
            {
                case WindowState.Maximized:
                    // fullscreenButton.ToolTip = "Restore"; //this is working backward
                    this.WindowState = WindowState.Normal;
                    break;
                case WindowState.Normal:
                    // fullscreenButton.ToolTip = "Full Screen";
                    this.WindowState = WindowState.Maximized;
                    break;

            }


            //if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
            //{
            //    this.WindowState = WindowState.Maximized;
            //}
            //else
            //{
            //    this.WindowState = WindowState.Normal;
            //}
        }


        private void dragWindow(object sender, MouseButtonEventArgs e)
        {
            
                this.DragMove();
            
        }

        #endregion


        #region Display Date/Time
        public void Display_Date()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start();

        }

        private void tickevent(object sender, EventArgs e)
        {

            this.labelDateTime.Content = DateTime.Now.ToString("dddd  yyyy/MM/dd  h:mm:ss tt");
            

        }
        #endregion
    }
}