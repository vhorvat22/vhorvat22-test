using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FinanceTrackerTests
{
    [TestClass]
    public class FinanceTrackTests
    {
        private FinanceTrack tracker;

        [TestInitialize]
        public void Setup()
        {
            tracker = new FinanceTrack();
        }

        [TestMethod]
        public void AddTransaction_ShouldAddTransactionToList()
        {
            // Arrange
            decimal amount = 100m;
            string description = "Test Transaction";

            // Act
            tracker.AddTransaction(amount, description);

            // Assert
            List<Transaction> transactions = tracker.ViewTransactions();
            Assert.AreEqual(1, transactions.Count);
            Assert.AreEqual(amount, transactions[0].Amount);
            Assert.AreEqual(description, transactions[0].Description);
        }

        [TestMethod]
        public void CalculateBalance_ShouldReturnCorrectBalance()
        {
            // Arrange
            tracker.AddTransaction(50, "Deposit");
            tracker.AddTransaction(100, "Test2");
            tracker.AddTransaction(-25, "Withdrawal");

            // Act
            decimal balance = tracker.CalculateBalance();

            // Assert
            Assert.AreEqual(125m, balance);
        }
    }
}
