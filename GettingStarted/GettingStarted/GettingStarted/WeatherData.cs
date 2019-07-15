using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GettingStarted
{
    public class WeatherData : INotifyPropertyChanged
    {
        private string _temperature;

        public WeatherData(string temperature)
        {
            Temperature = temperature;
        }

        public string Temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                _temperature = value;
                RaisePropertyChanged("Temperature");
            }
        }

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(String Name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(Name));
        }

        #endregion
    }
}
