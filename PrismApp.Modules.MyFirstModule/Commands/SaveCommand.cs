using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Commands;
using PrismApp.Modules.MyFirstModule.ViewModels;
using System.Windows.Input;

namespace PrismApp.Modules.MyFirstModule.Commands
{
    public class SaveCommand : ICommand
    {
        private readonly MyModuleMainViewModel _viewModel;

        public SaveCommand(MyModuleMainViewModel viewModel)
        {
            if (viewModel == null) 
                throw new ArgumentNullException("viewModel");
            
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _viewModel.Message = "Save command executed.";
        }
    }
}
