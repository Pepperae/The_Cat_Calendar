using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Cat_Cafe_API
{
    public class Customers : ICustomer
    {
        public string Name { get; set; }

        public string DateOfBirth { get; set; }

    }
}
