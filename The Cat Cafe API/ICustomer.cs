using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Cat_Cafe_API
{
    public interface ICustomer
    {
        string Name { get; set; }
        string DateOfBirth { get; set; }
    }
}
