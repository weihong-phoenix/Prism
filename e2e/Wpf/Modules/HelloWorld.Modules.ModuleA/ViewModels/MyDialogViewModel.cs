using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Modules.ModuleA.ViewModels
{
    internal partial class MyDialogViewModel : BindableBase, IDialogAware
    {
        public MyDialogViewModel()
        {
        }

        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }
        private string _firstName = "";

        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }
        private string _lastName = "";

        public string FullName => $"{_firstName} {_lastName}";

        public DelegateCommand SubmitCommand =>
            _submitCommand ?? (_submitCommand = new DelegateCommand(Submit));
        private DelegateCommand _submitCommand;

        void Submit()
        {
            FirstName = LastName = String.Empty;
        }

        #region IDialogAware implementation
        
        public string Title => "MODULE A";

        public event Action<IDialogResult> RequestClose;

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
            Debug.WriteLine("IDialogAware.OnDialogClosed");
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            Debug.WriteLine("IDialogAware.OnDialogOpened");
        }

        #endregion
    }
}
