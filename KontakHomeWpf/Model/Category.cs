using PropertyChanged;

namespace KontakHomeWpf.Model
{
    [AddINotifyPropertyChangedInterface]
    public class Category:DomainObject
    {
        public string Name { get; set; }
        public Category BaseCategory { get; set; }
    }
}