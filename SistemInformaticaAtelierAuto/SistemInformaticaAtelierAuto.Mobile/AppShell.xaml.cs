using SistemInformaticaAtelierAuto.Mobile.Views;

namespace SistemInformaticaAtelierAuto.Mobile
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(AddProgramarePage), typeof(AddProgramarePage));
        }
    }
}
