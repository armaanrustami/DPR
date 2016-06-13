using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    internal class Brand
    {
        private List<ISmartPhone> smartPhone = new List<ISmartPhone>();

        public void add(ISmartPhone phone)
        {
            smartPhone.Add(phone);
        }

        public List<ISmartPhone> getPhones()
        {
            return smartPhone;
        }
        public void removeItem(ISmartPhone item) { smartPhone.Remove(item); }
    }
}