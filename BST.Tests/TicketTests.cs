using Microsoft.VisualStudio.TestTools.UnitTesting;
using BST.Services;

namespace BST_Test
{
    [TestClass]
    public class TicketTests
    {
        private TicketService ticketService;

        [TestInitialize]
        public void Setup()
        {
            ticketService = new TicketService();
        }

        [TestMethod]
        public void BookTicket_ValidData_ReturnsTrue()
        {
            bool result = ticketService.BookTicket(1, 1, 1, 100);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void BookTicket_TooManySeats_ReturnsFalse()
        {
            bool result = ticketService.BookTicket(1, 1, 999, 100);

            Assert.IsFalse(result);
        }


        [TestMethod]
        public void GetUserTickets_ValidUser_ReturnsList()
        {
            var tickets = ticketService.GetUserTickets(1);

            Assert.IsNotNull(tickets);
        }

        [TestMethod]
        public void GetUserTickets_InvalidUser_ReturnsEmpty()
        {
            var tickets = ticketService.GetUserTickets(-1);

            Assert.IsNotNull(tickets);
        }

        [TestMethod]
        public void GetAllTickets_ReturnsDataTable()
        {
            var table = ticketService.GetAllTickets();

            Assert.IsNotNull(table);
        }
    }
}
