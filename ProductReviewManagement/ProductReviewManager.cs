using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ProductReviewManagement
{
    public class ProductReviewManager
    {
        /// <summary>
        /// Create list and objects to the list
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        public  int AddProductReviewToList(List<ProductReview> products)
        {
            try
            {
                //Adding 25 entries to list
                products.Add(new ProductReview() { productId = 2, userId = 6, review = "Average", rating = 10, isLike = true });
                products.Add(new ProductReview() { productId = 4, userId = 7, review = "Good", rating = 5, isLike = true });
                products.Add(new ProductReview() { productId = 19, userId = 8, review = "Average", rating = 10, isLike = true });
                products.Add(new ProductReview() { productId = 3, userId = 9, review = "Bad", rating = 6, isLike = false });
                products.Add(new ProductReview() { productId = 5, userId = 4, review = "Average", rating = 5, isLike = true });
                products.Add(new ProductReview() { productId = 9, userId = 8, review = "Average", rating = 10, isLike = true });
                products.Add(new ProductReview() { productId = 3, userId = 9, review = "Bad", rating = 6, isLike = false });
                products.Add(new ProductReview() { productId = 5, userId = 4, review = "Average", rating = 3, isLike = true });
                products.Add(new ProductReview() { productId = 2, userId = 5, review = "Bad", rating = 7, isLike = false });
                products.Add(new ProductReview() { productId = 1, userId = 1, review = "Very Good", rating = 9, isLike = true });
                products.Add(new ProductReview() { productId = 2, userId = 6, review = "Average", rating = 10, isLike = true });
                products.Add(new ProductReview() { productId = 4, userId = 7, review = "Good", rating = 5, isLike = true });
                products.Add(new ProductReview() { productId = 1, userId = 1, review = "Good", rating = 9, isLike = true });
                products.Add(new ProductReview() { productId = 2, userId = 2, review = "Average", rating = 8, isLike = true });
                products.Add(new ProductReview() { productId = 1, userId = 2, review = "Bad", rating = 8, isLike = false });
                products.Add(new ProductReview() { productId = 4, userId = 9, review = "Average", rating = 7, isLike = true });
                products.Add(new ProductReview() { productId = 3, userId = 11, review = "Good", rating = 5, isLike = true });
                products.Add(new ProductReview() { productId = 3, userId = 4, review = "Good", rating = 9, isLike = true });
                products.Add(new ProductReview() { productId = 7, userId = 10, review = "Very Good", rating = 8, isLike = true });
                products.Add(new ProductReview() { productId = 9, userId = 5, review = "Very Good", rating = 7, isLike = true });
                products.Add(new ProductReview() { productId = 10, userId = 3, review = "Bad", rating = 9, isLike = false });
                products.Add(new ProductReview() { productId = 12, userId = 3, review = "Bad", rating = 6, isLike = false });
                products.Add(new ProductReview() { productId = 14, userId = 15, review = "Very Good", rating = 9, isLike = true });
                products.Add(new ProductReview() { productId = 18, userId = 9, review = "Bad", rating = 7, isLike = false });
                products.Add(new ProductReview() { productId = 13, userId = 1, review = "Very Good", rating = 6, isLike = true });

                //IterateList(products);
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
            return products.Count;
        }
        /// <summary>
        /// Iterate through list and print
        /// </summary>
        /// <param name="products"></param>
        public static void IterateList(List<ProductReview> products)
        {
            try
            {
                foreach (ProductReview i in products)
                {
                    Console.WriteLine($"ProductId:{i.productId}\t UserId:{i.userId}\t Review:{i.review}\tRating:{i.rating}\tIsLike:{i.isLike}\t");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        /// <summary>
        /// Method to retreive top 3 ratings records
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        public int RetrieveTopThreeRating(List<ProductReview> products)
        {
            
            try
            {
                AddProductReviewToList(products);
                //Using Linq sort product list in descending order and take first 3 elements
                var res = (from product in products orderby product.rating descending select product).Take(3).ToList();
                Console.WriteLine("----------------------PRINTING TOP # RATING----------------------");
                IterateList(res);
                return res.Count;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            
            
        }
        /// <summary>
        /// Method to retreive particular records
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        public int RetrieveParticularRating(List<ProductReview> products)
        {
            AddProductReviewToList(products);
            //Using Linq retreive particular records
            var res = (from product in products where (product.productId == 1 || product.productId == 4 || product.productId == 9) && product.rating > 6 select product).ToList();
            Console.WriteLine("----------------------PRINTING Records----------------------");
            IterateList(res);
            return res.Count;
        }

        /// <summary>
        /// Method to retreive group by product i and count
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        public int ProductIdCount(List<ProductReview> products)
        {
            //counter variable
            int c = 0;
            AddProductReviewToList(products);
            //Using Linq retreive particular records
            var res = products.GroupBy(x => x.productId).Select(product => new {productId = product.Key, Count= product.Count() });
            Console.WriteLine("----------------------PRINTING Records----------------------");
            foreach(var i in res)
            {
               
               //increment the count
                c++;
            }
            return c;
        }
        /// <summary>
        /// Method to retreive only id and review using select
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        public int RetrieveProductIdAndReview(List<ProductReview> products)
        {
            //counter variable
            int c = 0;
            AddProductReviewToList(products);
            var res = products.Select(product => new { productId = product.productId, review = product.review }).ToList();
            foreach (var i in res)
            {
                Console.WriteLine($"ProductId = {i.productId}\t Reviews={i.review}\n");
                //increment the count
                c++;
            }
            return c;
        }



    }
}
