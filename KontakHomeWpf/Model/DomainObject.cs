using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace KontakHomeWpf.Model
{
    [AddINotifyPropertyChangedInterface]
    public class DomainObject
    {
        public int Id { get; set; }
    }
}
