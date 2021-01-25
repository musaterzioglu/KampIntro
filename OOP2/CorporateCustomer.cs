using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //miras inheritance
    class CorporateCustomer:Customer
    {
        public string CorporateName { get; set; }
        public string TaxIDNumber { get; set; }
    }
}
