using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace KontakHomeWpf.Model
{
    [AddINotifyPropertyChangedInterface]
    public class DictionaryProduct:DomainObject
    {
        public string PropType { get; set; }
        public string PropName { get; set; }
        public Product product { get; set; }
    }
}
