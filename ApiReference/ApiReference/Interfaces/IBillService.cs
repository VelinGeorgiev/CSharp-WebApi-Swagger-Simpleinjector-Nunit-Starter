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
        decimal Pay(decimal amount);
        object Reimburse(int id, decimal amount);
        bool Reverse(int id);
    }
}
