using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace KontakHomeWpf.Model
{
    [AddINotifyPropertyChangedInterface]
    public class Product:DomainObject
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public List<DictionaryProduct> Properts { get; set; }
        public Delivery Delivery { get; set; }
        public Category category { get; set; } 
    }
}
