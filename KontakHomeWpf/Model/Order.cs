using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace KontakHomeWpf.Model
{
    [AddINotifyPropertyChangedInterface]
    public class Order:DomainObject
    {
        public enum OrderCompletion { PayinCashUponDelivery, PayByCreditCarduponDelivery, PayOnlineOnTheSite, BuyWithACard }
        public Contact Contactt { get; set; }
        public Delivery Deliveryy { get; set; }
    }
}
