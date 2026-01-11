using SistemInformaticaAtelierAuto.Mobile.Models;
using SistemInformaticaAtelierAuto.Mobile.Services;
using SistemInformaticaAtelierAuto.Mobile.ViewModels;

namespace SistemInformaticaAtelierAuto.Mobile.Views;

[QueryProperty(nameof(Programare), "Programare")]
public partial class EditProgramarePage : ContentPage
{
    private readonly ProgramariService _service;
    private Programare _programare;

    public Programare Programare
    {
        set
        {
            _programare = value;
            BindingContext = new EditProgramareViewModel(_service, _programare);
        }
    }

    public EditProgramarePage(ProgramariService service)
    {
        InitializeComponent();
        _service = service;
    }
}
