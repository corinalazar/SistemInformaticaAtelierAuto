using System.Collections.ObjectModel;
using SistemInformaticaAtelierAuto.Mobile.Models;
using SistemInformaticaAtelierAuto.Mobile.Services;

namespace SistemInformaticaAtelierAuto.Mobile.ViewModels
{
    public class ProgramariViewModel
    {
        public ObservableCollection<Programare> Programari { get; }

        public ProgramariViewModel(ProgramariService service)
        {
            Programari = service.Programari;
        }
    }
}
