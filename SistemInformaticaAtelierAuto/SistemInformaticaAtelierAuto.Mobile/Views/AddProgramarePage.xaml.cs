using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemInformaticaAtelierAuto.Mobile.Services;
using SistemInformaticaAtelierAuto.Mobile.ViewModels;

namespace SistemInformaticaAtelierAuto.Mobile.Views
{
    public partial class AddProgramarePage : ContentPage
    {
        public AddProgramarePage(ProgramariService service)
        {
            InitializeComponent();
            BindingContext = new AddProgramareViewModel(service);
        }
    }
}
