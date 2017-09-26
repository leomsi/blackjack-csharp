using System;
using Blackjack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Black_Jack;

namespace Blackjack.Tests
{
    [TestClass]
    public class BlackjackTests
    {
        [TestMethod]
        public void ShowCardsTest()
        {
            //arrange
            int humanScore = 23;
            int computerScore = 20;
            string expectedResult = "\nHuman Won!";
            ShowCards showCards = new ShowCards();
            
            //act    
            string actualResult = showCards.Check(humanScore, computerScore);
            
            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}
