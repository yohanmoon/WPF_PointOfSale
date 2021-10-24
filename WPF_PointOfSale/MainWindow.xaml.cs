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
using System.Windows.Threading; //Timer

namespace WPF_PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //HomeMenuList.SelectedItem = HomePg; //If I was using Menu ListView
            HomeButton.IsChecked = true;
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
                    fullscreenButton.ToolTip = "Fullscreen"; //this is working backward
                    
                    
                    FullScreenExit.Visibility = Visibility.Collapsed;
                    FullScreen.Visibility = Visibility.Visible;
                    this.WindowState = WindowState.Normal;
                    break;
                case WindowState.Normal:
                    fullscreenButton.ToolTip = "Normal Screen";
                    
                    
                    FullScreenExit.Visibility = Visibility.Visible;
                    FullScreen.Visibility = Visibility.Collapsed;
                    this.WindowState = WindowState.Maximized;
                    break;

            }


            //    if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
            //    {
            //        FullScreenExit.Visibility = Visibility.Hidden;
            //        FullScreen.Visibility = Visibility.Visible;
            //        this.WindowState = WindowState.Maximized;
            //    }
            //    else
            //    {
            //        FullScreenExit.Visibility = Visibility.Visible;
            //        FullScreen.Visibility = Visibility.Hidden;
            //        this.WindowState = WindowState.Normal;
            //    }
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

            this.labelDateTime.Content = DateTime.Now.ToString("dddd   MM/dd/yyyy   h:mm:ss tt");


        }
        #endregion
    }
}

