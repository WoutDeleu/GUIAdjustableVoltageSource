using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Text.RegularExpressions;


namespace AdjustableVoltageSource
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class SettingScreen : Window, INotifyPropertyChanged
    {
        private int _boardNumber;
        public int BoardNumber 
        {
            get { return _boardNumber; }
            set
            {
                if(value != _boardNumber)
                {
                    _boardNumber = value;
                    OnPropertyChanged("BoardNumber");
                }
            }
        }
        public SettingScreen()
        {
            InitializeComponent();
            BoardNumber = getBoardNumberArduino();

            Current_BoardNumber.SetBinding(ContentProperty, new Binding("BoardNumber"));
            DataContext = this;
        }
        private void CancelBoardNumber(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void ApplyBoardNumber(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            String boardNumberStr = NewBoardNumber.Text;
            Debug.WriteLine(boardNumberStr);
            if (isValidBoardNumber(boardNumberStr))
            {
                BoardNumber = Convert.ToInt32(boardNumberStr);

                //setBoardNumberArduino(boardNumber);
            }
            else
            {
                Debug.WriteLine("Fault in fomrat input");
                // TODO
                // ... -> foutmelding
            }
        }
        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            var handler = System.Threading.Interlocked.CompareExchange(ref PropertyChanged, null, null);
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion

        // TODO
        /*private void setBoardNumberArduino(int boardNumber)
        {
            throw new NotImplementedException();
        }*/

        // TODO
        private int getBoardNumberArduino()
        {
            return 154;
        }

        private Boolean isValidBoardNumber(String s)
        {
            return Regex.IsMatch(s, @"^\d+$");
        }
    }
}
