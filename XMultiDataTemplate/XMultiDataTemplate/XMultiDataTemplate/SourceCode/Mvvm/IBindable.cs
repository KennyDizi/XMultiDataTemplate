﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XMultiDataTemplate.SourceCode.Mvvm
{
    // this exists for the future implementation of the INPC property attribute
    public interface IBindable : INotifyPropertyChanged
    {
        void RaisePropertyChanged([CallerMemberName]string propertyName = null);
    }
}
