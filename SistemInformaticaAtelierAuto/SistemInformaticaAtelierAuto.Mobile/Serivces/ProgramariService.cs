using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using SistemInformaticaAtelierAuto.Mobile.Models;

namespace SistemInformaticaAtelierAuto.Mobile.Services
{
    public class ProgramariService
    {
        public ObservableCollection<Programare> Programari { get; } =
            new ObservableCollection<Programare>();

        public void AddProgramare(Programare programare)
        {
            Programari.Add(programare);
        }
    }
}
