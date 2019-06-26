using PJK.PRISM.HCIS_2.UI.ViewModels;
using PJK.PRISM.HCIS_2.UI.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace PJK.PRISM.HCIS_2.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<Splash>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
