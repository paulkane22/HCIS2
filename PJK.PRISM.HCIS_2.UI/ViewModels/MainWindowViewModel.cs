using Prism.Mvvm;

namespace PJK.PRISM.HCIS_2.UI.ViewModels
{
    public class MainWindowViewModel : BindableBase, IWindowViewModel
    {
        private string _title = "HCIS II";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _statusBarMessage = "HCIS II";
        public string StatusBarMessage
        {
            get { return _statusBarMessage; }
            set { SetProperty(ref _statusBarMessage, value); }
        }


        public MainWindowViewModel()
        {

        }
    }
}
