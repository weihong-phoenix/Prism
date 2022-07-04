using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using HelloWorld.Core;
using HelloWorld.Modules.ModuleA.Views;

namespace HelloWorld.Modules.ModuleA.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private readonly IDialogService _dialogService;

        public ViewAViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
        private string _message = "Hello from ViewA in Module A";

        public DelegateCommand ShowDialogCommand => _showDialogCommand ??= new DelegateCommand(ShowDialog);
        private DelegateCommand _showDialogCommand;

        void ShowDialog()
        {
            _dialogService.ShowDialog<MyDialog>();
            // _dialogService.ShowDialog("MyDialog", null, null);
        }
    }
}
