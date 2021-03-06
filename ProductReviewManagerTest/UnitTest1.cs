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
                Assert.AreEqual(expected, actual);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        /// <summary>
        /// test method to group by and count by product id
        /// </summary>
        [TestMethod]
        public void TestMethodCountProductId()
        {
            try
            {
                int actual, expected = 13;
                actual = reviewManager.ProductIdCount(reviewList);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        /// <summary>
        /// test method to retreive only id and review using select
        /// </summary>
        [TestMethod]
        public void TestMethodRetrieveProductIdAndReview()
        {
            try
            {
                int actual, expected = 25;
                actual = reviewManager.RetrieveProductIdAndReview(reviewList);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        /// <summary>
        /// test method to skip 5 records
        /// </summary>
        [TestMethod]
        public void TestMethodForSkipFiveRecords()
        {
            try
            {
                int actual, expected = 20;
                actual = reviewManager.SkipFiveRecords(reviewList);
                Assert.AreEqual(expected,actual);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        /// <summary>
        /// test method Create datatable
        /// </summary>
        [TestMethod]
        public void TestMethodCreateDatatable()
        {
            try
            {
                reviewManager.CreateDataTable(reviewList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Test method retreive only records where is like is true
        /// </summary>
        [TestMethod]
        public void TestMethodRetreiveBasedOnIsLike()
        {
            try
            {
                int actual, expected = 15;
                actual = reviewManager.RetreiveBasedOnIsLike(reviewList);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Test method to find average of product rating
        /// </summary>
        [TestMethod]
        public void TestMethodFindAverageOfProductRating()
        {
            try
            {
                double actual, expected = 7.36;
                actual = reviewManager.FindAverageOfProductRating(reviewList);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Test method retreive only rating contains good
        /// </summary>
        [TestMethod]
        public void TestMethodRetreiveGoodRatings()
        {
            try
            {
                int actual, expected = 10;
                actual = reviewManager.RetreiveGoodRatings(reviewList);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Test method retreive based on user id
        /// </summary>
        [TestMethod]
        public void TestMethodRetreiveBasedOnUserId()
        {
            try
            {
                int actual, expected = 5;
                actual = reviewManager.RetreiveBasedOnUserId(reviewList);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
