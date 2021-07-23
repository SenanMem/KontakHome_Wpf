using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace KontakHomeWpf.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class BaseVModels
    {
        public BaseVModels CurrentVModels { get; set; }
    }
}
