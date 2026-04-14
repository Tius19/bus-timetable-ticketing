using Microsoft.VisualStudio.TestTools.UnitTesting;
using BST.Services;

namespace BST_Test
{
    [TestClass]
    public class PaymentTests
    {
        private PaymentService paymentService;

        [TestInitialize]
        public void Setup()
        {
            paymentService = new PaymentService();
        }

        [TestMethod]
        public void ProcessPayment_ValidData_Executes()
        {
            paymentService.ProcessPayment(1, 1, 100);

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void ProcessPayment_MultiplePayments_Executes()
        {
            paymentService.ProcessPayment(1, 1, 50);
            paymentService.ProcessPayment(1, 1, 75);

            Assert.IsTrue(true);
        }
    }
}