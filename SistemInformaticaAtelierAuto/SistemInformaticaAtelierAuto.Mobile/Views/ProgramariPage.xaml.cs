using SistemInformaticaAtelierAuto.Mobile.Services;
using SistemInformaticaAtelierAuto.Mobile.ViewModels;

namespace SistemInformaticaAtelierAuto.Mobile.Views
{
    public partial class ProgramariPage : ContentPage
    {
        public ProgramariPage(ProgramariService service)
        {
            InitializeComponent();
            BindingContext = new ProgramariViewModel(service);
        }
    }
}
