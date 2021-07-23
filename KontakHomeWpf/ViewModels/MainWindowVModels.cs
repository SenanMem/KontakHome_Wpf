using KontakHomeWpf.Repository;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace KontakHomeWpf.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainWindowVModels:BaseVModels
    {
        public ApplicationContext db { get; set; }
        public BaseVModels CurrentVModels { get; set; }
        private HeaderVModels _headerVModels { get; set; }
        public MainWindowVModels()
        {
            db = new ApplicationContext();
            _headerVModels = new HeaderVModels(db);
            CurrentVModels = _headerVModels;
        }
    }
}
