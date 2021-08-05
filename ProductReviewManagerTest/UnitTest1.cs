using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductReviewManagement;
using System.Collections.Generic;
using System;

namespace ProductReviewManagerTest
{
    [TestClass]
    public class UnitTest1
    {
        ProductReviewManager reviewManager;
        List<ProductReview> reviewList;
        /// <summary>
        /// Method to initialize objects
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            reviewList = new List<ProductReview>();
            reviewManager = new ProductReviewManager();
        }
        /// <summary>
        /// Test method to create and add reviews to the list
        /// </summary>
        [TestMethod]
        public void TestMethodForAddToList()
        {
            try
            {
                int actual, expected = 25;
                actual = reviewManager.AddingProductReview(reviewList);
                Assert.AreEqual(actual, expected);
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            
            
        }
    }
}
