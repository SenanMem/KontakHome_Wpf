using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace KontakHomeWpf.Model
{
    [AddINotifyPropertyChangedInterface]
    public class Box :DomainObject
    {
        public List<Product> Products { get; set; }
    }
}
