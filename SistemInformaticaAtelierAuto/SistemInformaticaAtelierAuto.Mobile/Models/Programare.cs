using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SistemInformaticaAtelierAuto.Mobile.Models
{
    public class Programare : INotifyPropertyChanged
    {
        private string _masina;
        private DateTime _data;
        private string _descriere;

        public string Masina
        {
            get => _masina;
            set
            {
                _masina = value;
                OnPropertyChanged();
            }
        }

        public DateTime Data
        {
            get => _data;
            set
            {
                _data = value;
                OnPropertyChanged();
            }
        }

        public string Descriere
        {
            get => _descriere;
            set
            {
                _descriere = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
