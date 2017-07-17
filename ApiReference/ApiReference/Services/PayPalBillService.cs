using ApiReference.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiReference.Services
{
    public class PayPalBillService : IBillService
    {
        public string GetById(int id)
        {
            return "value";
        }

        public object Pay(decimal amount)
        {
            throw new NotImplementedException();
        }

        public object Reimburse(int id, decimal amount)
        {
            throw new NotImplementedException();
        }

        public object Reverse(int id)
        {
            throw new NotImplementedException();
        }
    }
}