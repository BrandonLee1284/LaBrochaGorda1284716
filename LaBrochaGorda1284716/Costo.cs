using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBrochaGorda1284716
{
    public class Costo : INotifyPropertyChanged
    {

        private double _precioPorMetro;
        private double _area;
        private double _total;

        public double PrecioPorMetro
        {
            get => _precioPorMetro;
            set
            {
                if (_precioPorMetro != value)
                {
                    _precioPorMetro = value;
                    OnPropertyChanged(nameof(PrecioPorMetro));
                    OnPropertyChanged(nameof(Total));
                }
            }
        }

        public double Area
        {
            get => _area;
            set
            {
                if (_area != value)
                {
                    _area = value;
                    OnPropertyChanged(nameof(Area));
                    OnPropertyChanged(nameof(Total));
                }
            }
        }

        public double Total => PrecioPorMetro * Area;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
