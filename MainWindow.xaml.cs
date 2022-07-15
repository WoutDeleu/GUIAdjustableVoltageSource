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
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Diagnostics;

namespace AdjustableVoltageSource
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool ConnectedToGround_1 { get; set; }
        public bool ConnectedToGround_2 { get; set; }
        public bool ConnectedToGround_3 { get; set; }
        public bool ConnectedToGround_4 { get; set; }
        public bool ConnectedToGround_5 { get; set; }
        public bool ConnectedToGround_6 { get; set; }
        public bool ConnectedToGround_7 { get; set; }
        public bool ConnectedToGround_8 { get; set; }
        public bool ConnectedToGround_9 { get; set; }
        public bool ConnectedToGround_10 { get; set; }
        public bool ConnectedToGround_11 { get; set; }
        public bool ConnectedToGround_12 { get; set; }
        public bool ConnectedToGround_13 { get; set; }
        public bool ConnectedToGround_14 { get; set; }
        public bool ConnectedToGround_15 { get; set; }
        public bool ConnectedToGround_16 { get; set; }

        public bool ConnectedToBus_1 { get; set; }
        public bool ConnectedToBus_2 { get; set; }
        public bool ConnectedToBus_3 { get; set; }
        public bool ConnectedToBus_4 { get; set; }
        public bool ConnectedToBus_5 { get; set; }
        public bool ConnectedToBus_6 { get; set; }
        public bool ConnectedToBus_7 { get; set; }
        public bool ConnectedToBus_8 { get; set; }
        public bool ConnectedToBus_9 { get; set; }
        public bool ConnectedToBus_10 { get; set; }
        public bool ConnectedToBus_11 { get; set; }
        public bool ConnectedToBus_12 { get; set; }
        public bool ConnectedToBus_13 { get; set; }
        public bool ConnectedToBus_14 { get; set; }
        public bool ConnectedToBus_15 { get; set; }
        public bool ConnectedToBus_16 { get; set; }


        private void ConnectBus1(object sender, RoutedEventArgs e)
        {
            ConnectedToBus_1 = !ConnectedToBus_1;
            if (updated) updated = false;
        }
        private void ConnectBus2(object sender, RoutedEventArgs e)
        {
            ConnectedToBus_2 = !ConnectedToBus_2;
            if (updated) updated = false;
        }
        private void ConnectBus3(object sender, RoutedEventArgs e)
        {
            ConnectedToBus_3 = !ConnectedToBus_3;
            if (updated) updated = false;
        }
        private void ConnectBus4(object sender, RoutedEventArgs e)
        {
            ConnectedToBus_4 = !ConnectedToBus_4;
            if (updated) updated = false;
        }
        private void ConnectBus5(object sender, RoutedEventArgs e)
        {
            ConnectedToBus_5 = !ConnectedToBus_5;
            if (updated) updated = false;
        }
        private void ConnectBus6(object sender, RoutedEventArgs e)
        {
            ConnectedToBus_6 = !ConnectedToBus_6;
            if (updated) updated = false;
        }
        private void ConnectBus7(object sender, RoutedEventArgs e)
        {
            ConnectedToBus_7 = !ConnectedToBus_7;
            if (updated) updated = false;
        }
        private void ConnectBus8(object sender, RoutedEventArgs e)
        {
            ConnectedToBus_8 = !ConnectedToBus_8;
            if (updated) updated = false;
        }
        private void ConnectBus9(object sender, RoutedEventArgs e)
        {
            ConnectedToBus_9 = !ConnectedToBus_9;
            if (updated) updated = false;
        }
        private void ConnectBus10(object sender, RoutedEventArgs e)
        {
            ConnectedToBus_10 = !ConnectedToBus_10;
            if (updated) updated = false;
        }
        private void ConnectBus11(object sender, RoutedEventArgs e)
        {
            ConnectedToBus_11 = !ConnectedToBus_11;
            if (updated) updated = false;
        }
        private void ConnectBus12(object sender, RoutedEventArgs e)
        {
            ConnectedToBus_12 = !ConnectedToBus_12;
            if (updated) updated = false;
        }
        private void ConnectBus13(object sender, RoutedEventArgs e)
        {
            ConnectedToBus_13 = !ConnectedToBus_13;
            if (updated) updated = false;
        }
        private void ConnectBus14(object sender, RoutedEventArgs e)
        {
            ConnectedToBus_14 = !ConnectedToBus_14;
            if (updated) updated = false;
        }
        private void ConnectBus15(object sender, RoutedEventArgs e)
        {
            ConnectedToBus_15 = !ConnectedToBus_15;
            if (updated) updated = false;
        }
        private void ConnectBus16(object sender, RoutedEventArgs e)
        {
            ConnectedToBus_16 = !ConnectedToBus_16;
            if (updated) updated = false;
        }


        private void ConnectGnd1(object sender, RoutedEventArgs e)
        {
            ConnectedToGround_1 = !ConnectedToGround_1;
            if (updated) updated = false;
        }
        private void ConnectGnd2(object sender, RoutedEventArgs e)
        {
            ConnectedToGround_2 = !ConnectedToGround_2;
            if (updated) updated = false;
        }
        private void ConnectGnd3(object sender, RoutedEventArgs e)
        {
            ConnectedToGround_3 = !ConnectedToGround_3;
            if (updated) updated = false;
        }
        private void ConnectGnd4(object sender, RoutedEventArgs e)
        {
            ConnectedToGround_4 = !ConnectedToGround_4;
            if (updated) updated = false;
        }
        private void ConnectGnd5(object sender, RoutedEventArgs e)
        {
            ConnectedToGround_5 = !ConnectedToGround_5;
            if (updated) updated = false;
        }
        private void ConnectGnd6(object sender, RoutedEventArgs e)
        {
            ConnectedToGround_6 = !ConnectedToGround_6;
            if (updated) updated = false;
        }
        private void ConnectGnd7(object sender, RoutedEventArgs e)
        {
            ConnectedToGround_7 = !ConnectedToGround_7;
            if (updated) updated = false;
        }
        private void ConnectGnd8(object sender, RoutedEventArgs e)
        {
            ConnectedToGround_8 = !ConnectedToGround_8;
            if (updated) updated = false;
        }
        private void ConnectGnd9(object sender, RoutedEventArgs e)
        {
            ConnectedToGround_9 = !ConnectedToGround_9;
            if (updated) updated = false;
        }
        private void ConnectGnd10(object sender, RoutedEventArgs e)
        {
            ConnectedToGround_10 = !ConnectedToGround_10;
            if (updated) updated = false;
        }
        private void ConnectGnd11(object sender, RoutedEventArgs e)
        {
            ConnectedToGround_11 = !ConnectedToGround_11;
            if (updated) updated = false;
        }
        private void ConnectGnd12(object sender, RoutedEventArgs e)
        {
            ConnectedToGround_12 = !ConnectedToGround_12;
            if (updated) updated = false;
        }
        private void ConnectGnd13(object sender, RoutedEventArgs e)
        {
            ConnectedToGround_13 = !ConnectedToGround_13;
            if (updated) updated = false;
        }
        private void ConnectGnd14(object sender, RoutedEventArgs e)
        {
            ConnectedToGround_14 = !ConnectedToGround_14;
            if (updated) updated = false;
        }
        private void ConnectGnd15(object sender, RoutedEventArgs e)
        {
            ConnectedToGround_15 = !ConnectedToGround_15;
            if (updated) updated = false;
        }
        private void ConnectGnd16(object sender, RoutedEventArgs e)
        {
            ConnectedToGround_16 = !ConnectedToGround_16;
            if (updated) updated = false;
        }


        private bool updated { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            // ToDo
            // Arduino Setup methode?
        }
        private void OpenSettingScreen(object sender, RoutedEventArgs e)
        {
            SettingScreen settings = new SettingScreen();
            settings.ShowDialog();
        }
        private void OpenMeasureScreen(object sender, RoutedEventArgs e)
        {
            MeasureScreen measureScreen = new MeasureScreen();
            measureScreen.ShowDialog();
        }
        private void PutVoltage(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine(ConnectedToBus_1);
            Debug.WriteLine(ConnectedToBus_10);
            Debug.WriteLine(ConnectedToBus_16);
            Debug.WriteLine(ConnectedToGround_6);
            Debug.WriteLine(ConnectedToBus_8);
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            if (regex.IsMatch(e.Text))
            {
                if (Int32.Parse(e.Text) > 0 && Int32.Parse(e.Text) < 30)
                {
                    e.Handled = regex.IsMatch(e.Text);
                }
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
