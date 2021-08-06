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
                actual = reviewManager.AddProductReviewToList(reviewList);
                Assert.AreEqual(actual, expected);
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            
            
        }
        /// <summary>
        /// test method to retreive top 3 records
        /// </summary>
        [TestMethod]
        public void TestMethodRetreiveTop3()
        {
            try
            {
                int actual, expected = 3;
                actual = reviewManager.RetrieveTopThreeRating(reviewList);
                Assert.AreEqual(actual, expected);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }


        }

        /// <summary>
        /// test method to retreive particular records
        /// </summary>
        [TestMethod]
        public void TestMethodRetreiveParticularRecords()
        {
            try
            {
                int actual, expected = 6;
                actual = reviewManager.RetrieveParticularRating(reviewList);
                Assert.AreEqual(actual, expected);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }


        }
    }
}
