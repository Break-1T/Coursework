﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using Calculation_of_penalties.Annotations;

namespace Calculation_of_penalties.ViewModel.Base
{
    internal abstract class ViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
