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

        public decimal Pay(decimal amount)
        {
            return Math.Abs(amount);
        }

        public object Reimburse(int id, decimal amount)
        {
            throw new NotImplementedException();
        }

        public bool Reverse(int id)
        {
            return id % 2 == 0;
        }
    }
}