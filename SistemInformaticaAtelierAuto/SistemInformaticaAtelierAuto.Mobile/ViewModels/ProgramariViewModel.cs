using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using SistemInformaticaAtelierAuto.Mobile.Models;

namespace SistemInformaticaAtelierAuto.Mobile.ViewModels
{
    public class ProgramariViewModel
    {
        public ObservableCollection<Programare> Programari { get; set; }

        public ProgramariViewModel()
        {
            Programari = new ObservableCollection<Programare>
            {
                new Programare
                {
                    Masina = "Dacia Logan",
                    Data = DateTime.Now.AddDays(1),
                    Descriere = "Revizie periodică"
                },
                new Programare
                {
                    Masina = "VW Golf",
                    Data = DateTime.Now.AddDays(2),
                    Descriere = "Schimb ulei"
                }
            };
        }
    }
}
