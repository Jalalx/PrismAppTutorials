using System;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using PrismApp.Modules.MyFirstModule.Commands;
using System.Linq;
using System.Windows.Input;
using PrismApp.Modules.MyFirstModule.Services;

namespace PrismApp.Modules.MyFirstModule.ViewModels
{
    public class MyModuleMainViewModel : NotificationObject
    {
        private readonly INameService _textService;

        public MyModuleMainViewModel(INameService textService)
        {
            _textService = textService;
            SaveCommand = new DelegateCommand(Save, CanSave);
            ModuleCommands.SaveCommand.RegisterCommand(SaveCommand);
        }

        private string _message = "Hello from My Module!";

        public string Message
        {
            get { return _message; }
            set
            {
                if (_message != value)
                {
                    _message = value;
                    RaisePropertyChanged(() => Message);
                }
            }
        }

        public ICommand SaveCommand { get; private set; }

        public void Save()
        {
            this.Message =  string.Format("Save Command Executed for {0}.", _textService.GetRandomName());
        }

        public bool CanSave()
        {
            return true;
        }

    }
}