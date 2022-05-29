using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using HelloWorld.Core;

namespace HelloWorld.Modules.ModuleB.ViewModels
{
    public class ViewBViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private DelegateCommand _showDialogCommand;
        private readonly IDialogService _dialogService;

        public DelegateCommand ShowDialogCommand =>
            _showDialogCommand ?? (_showDialogCommand = new DelegateCommand(ExecuteShowDialogCommand));

        void ExecuteShowDialogCommand()
        {
            _dialogService.ShowNotification("Hello There!", r =>
            {
                if (r.Result == ButtonResult.OK)
                    Message = "OK was clicked";
                else
                    Message = "Something else was clicked";
            });
        }

        public ViewBViewModel(IDialogService dialogService)
        {
            Message = "Hello from ViewB in Module B";
            _dialogService = dialogService;
        }
    }
}
