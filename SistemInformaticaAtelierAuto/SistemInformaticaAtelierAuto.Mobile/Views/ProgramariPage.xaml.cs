using System;
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

        private async void OnAddProgramareClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(AddProgramarePage));
        }
    }
}
