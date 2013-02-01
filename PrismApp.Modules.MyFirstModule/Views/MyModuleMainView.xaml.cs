using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PrismApp.Modules.MyFirstModule.ViewModels;

namespace PrismApp.Modules.MyFirstModule.Views
{
    /// <summary>
    /// Interaction logic for MyModuleMainView.xaml
    /// </summary>
    public partial class MyModuleMainView : TabItem
    {
        public MyModuleMainView(MyModuleMainViewModel viewModel)
        {
            InitializeComponent();
            this.Loaded += (obj, e) => this.DataContext = viewModel;
        }
    }
}
