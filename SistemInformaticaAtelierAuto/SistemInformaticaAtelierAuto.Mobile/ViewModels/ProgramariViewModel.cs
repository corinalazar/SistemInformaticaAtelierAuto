using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using SistemInformaticaAtelierAuto.Mobile.Models;
using SistemInformaticaAtelierAuto.Mobile.Services;

namespace SistemInformaticaAtelierAuto.Mobile.ViewModels
{
    public class ProgramariViewModel : INotifyPropertyChanged
    {
        private Programare _selectedProgramare;

        public ObservableCollection<Programare> Programari { get; }
        public ICommand AddProgramareCommand { get; }

        public Programare SelectedProgramare
        {
            get => _selectedProgramare;
            set
            {
                if (_selectedProgramare != value)
                {
                    _selectedProgramare = value;
                    OnPropertyChanged();

                    if (value != null)
                    {
                        Shell.Current.GoToAsync(
                            nameof(Views.EditProgramarePage),
                            new Dictionary<string, object>
                            {
                                { "Programare", value }
                            });

                  
                        _selectedProgramare = null;
                        OnPropertyChanged(nameof(SelectedProgramare));
                    }
                }
            }
        }

        public ProgramariViewModel(ProgramariService service)
        {
            Programari = service.Programari;

            AddProgramareCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync(nameof(Views.AddProgramarePage));
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
