using System;
using System.Windows.Input;
using SistemInformaticaAtelierAuto.Mobile.Models;
using SistemInformaticaAtelierAuto.Mobile.Services;

namespace SistemInformaticaAtelierAuto.Mobile.ViewModels
{
    public class AddProgramareViewModel
    {
        private readonly ProgramariService _service;

        public string Masina { get; set; } = string.Empty;
        public DateTime Data { get; set; } = DateTime.Now;
        public string Descriere { get; set; } = string.Empty;

        public ICommand SaveCommand { get; }

        public AddProgramareViewModel(ProgramariService service)
        {
            _service = service;
            SaveCommand = new Command(OnSave);
        }

        private async void OnSave()
        {
            _service.AddProgramare(new Programare
            {
                Masina = Masina,
                Data = Data,
                Descriere = Descriere
            });

            await Shell.Current.GoToAsync("..");
        }
    }
}

