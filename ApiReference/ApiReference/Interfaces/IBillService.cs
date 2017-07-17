using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiReference.Interfaces
{
    public interface IBillService
    {
        string GetById(int id);
        object Pay(decimal amount);
        object Reverse(int id);
        object Reimburse(int id, decimal amount);
    }
}
