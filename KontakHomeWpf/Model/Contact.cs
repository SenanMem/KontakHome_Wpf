using PropertyChanged;

namespace KontakHomeWpf.Model
{
    [AddINotifyPropertyChangedInterface]
    public class Contact:DomainObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
    }
}