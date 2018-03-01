using RootEmployees.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RootEmployees.ViewModels
{
    public class UserAuthVm : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string userName;
        public string User { get; set; }
    }
}
