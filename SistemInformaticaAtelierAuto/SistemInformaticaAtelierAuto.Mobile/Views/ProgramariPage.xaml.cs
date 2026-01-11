using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemInformaticaAtelierAuto.Mobile.ViewModels;

namespace SistemInformaticaAtelierAuto.Mobile.Views;

public partial class ProgramariPage : ContentPage
{
    public ProgramariPage()
    {
        InitializeComponent();
        BindingContext = new ProgramariViewModel();
    }
}
