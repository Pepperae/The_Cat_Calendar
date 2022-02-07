using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Cat_Cafe_API
{
    public interface ICat
    {
        string Name { get; set; }
        int Age { get; set; }
        string Gender { get; set; }
    }
}
