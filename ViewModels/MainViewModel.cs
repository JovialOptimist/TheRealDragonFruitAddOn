using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp2.Views;

namespace MauiApp2.ViewModels
{
    public partial class MainViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {
        public MainViewModel()
        {

        }
        
        [RelayCommand]
        public void RedirectSomeWhereCommand()
        {
            Shell.Current.GoToAsync(nameof(UserPage));
        }
    }
}
