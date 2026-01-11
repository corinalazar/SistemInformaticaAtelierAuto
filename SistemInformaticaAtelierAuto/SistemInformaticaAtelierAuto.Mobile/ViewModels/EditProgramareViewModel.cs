using System.Windows.Input;
using SistemInformaticaAtelierAuto.Mobile.Models;
using SistemInformaticaAtelierAuto.Mobile.Services;

namespace SistemInformaticaAtelierAuto.Mobile.ViewModels
{
    public class EditProgramareViewModel
    {
        private readonly ProgramariService _service;
        private readonly Programare _programare;

        public string Masina
        {
            get => _programare.Masina;
            set => _programare.Masina = value;
        }

        public DateTime Data
        {
            get => _programare.Data;
            set => _programare.Data = value;
        }

        public string Descriere
        {
            get => _programare.Descriere;
            set => _programare.Descriere = value;
        }

        public ICommand SaveCommand { get; }
        public ICommand DeleteCommand { get; }

        public EditProgramareViewModel(ProgramariService service, Programare programare)
        {
            _service = service;
            _programare = programare;

            SaveCommand = new Command(async () =>
                await Shell.Current.GoToAsync(".."));

            DeleteCommand = new Command(async () =>
            {
                _service.Programari.Remove(_programare);
                await Shell.Current.GoToAsync("..");
            });
        }
    }
}
