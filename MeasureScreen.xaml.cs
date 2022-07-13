using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace AdjustableVoltageSource
{

    public partial class MeasureScreen : Window, INotifyPropertyChanged
    {    
        private double _measuredValue;
        public double MeasuredValue
        {
            get { return _measuredValue; }
            set
            {
                if (value != _measuredValue)
                {
                    _measuredValue = value;
                    OnPropertyChanged("MeasuredValue");
                }
            }
        }
        public MeasureScreen()
        {
            InitializeComponent(); 
            Current_MeasuredValue.SetBinding(ContentProperty, new Binding("MeasuredValue"));
            DataContext = this;
            
        }
        private void CloseMeasureScreen(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void MeasureValue(object sender, RoutedEventArgs e)
        {
            MeasuredValue = 4;
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
    }
}
