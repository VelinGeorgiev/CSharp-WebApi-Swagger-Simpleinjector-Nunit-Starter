using System;
using NUnit.Framework;
using NSubstitute;
using ApiReference.Interfaces;
using ApiReference.Services;

namespace ApiReference.Tests
{
    [TestFixture]
    public class NSubstituteTest
    {
        private IBillService _billService;

        [SetUp]
        public void Initialize()
        {
            _billService = Substitute.For<IBillService>();

            // Fake a method.
            _billService.GetById(Arg.Any<int>()).Returns("stubValue");
        }

        [Test]
        [Description("Should assert the faked method instead of any actual implementation.")]
        public void NSubstitute_GetByIdCheck()
        {
            var bill = _billService.GetById(1);
            Assert.AreEqual(bill, "stubValue");
        }
    }
}
