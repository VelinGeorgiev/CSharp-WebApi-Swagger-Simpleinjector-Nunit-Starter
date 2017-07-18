using System;
using NUnit.Framework;
using NSubstitute;
using ApiReference.Interfaces;
using ApiReference.Services;

namespace ApiReference.Tests
{
    [TestFixture]
    public class PayPalBillTest
    {
        private IBillService _billService;

        [SetUp]
        public void Initialize()
        {
            _billService = new PayPalBillService();
        }

        [Test]
        public void PayPalBill_ReverseCheck()
        {
            var result = _billService.Reverse(2);
            Assert.IsTrue(result);
        }

        [TestCase(-2, 2)]
        [TestCase(4, 4)]
        [TestCase(0, 0)]
        [TestCase(-11, 11)]
        [Description("This test can get two values because of capsulated datetime.today in the code blocks. Once we decouple the code we can exclude the 0.63m result.")]
        public void PayPalBill_PayCheck(decimal amount, decimal expect)
        {
            var result = _billService.Pay(amount);
            Assert.AreEqual(result, expect);
        }

        [Test]
        [Description("Fail by purpose.")]
        public void PayPalBill_GetByIdCheck()
        {
            var bill = _billService.GetById(1);
            Assert.AreEqual(bill, "value");
        }
    }
}
