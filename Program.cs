namespace ProductReviewManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Review Management Problem ");

            List<ProductReview> ProductReviewList = new List<ProductReview>
            {
                new ProductReview(){ProductID=1,UserID=1,Rating=5,Review="Excellent",IsLike=true},
                new ProductReview(){ProductID=2,UserID=2,Rating=4,Review="Very good",IsLike=true},
                new ProductReview(){ProductID=3,UserID=3,Rating=3,Review="Good",IsLike=true },
                new ProductReview(){ProductID=10,UserID=4,Rating=2,Review=" Poor",IsLike=true},
                new ProductReview(){ProductID=6,UserID=5,Rating=1,Review="Very Poor",IsLike=false},
                new ProductReview(){ProductID=7,UserID=6,Rating=2,Review="Poor",IsLike=true},
                new ProductReview(){ProductID=10,UserID=7,Rating=3,Review="Good",IsLike=true},
                new ProductReview(){ProductID=9,UserID=8,Rating=4,Review="Very good",IsLike=true},
                new ProductReview(){ProductID=10,UserID=9,Rating=5,Review="Excellent",IsLike=true},
                new ProductReview(){ProductID=11,UserID=10,Rating=5,Review="Excellent",IsLike=true},
                new ProductReview(){ProductID=12,UserID=11,Rating=4,Review="Very good",IsLike=true},
                new ProductReview(){ProductID=5,UserID=12,Rating=3,Review="Good",IsLike=true},
                new ProductReview(){ProductID=14,UserID=13,Rating=2,Review="Poor",IsLike=true},
                new ProductReview(){ProductID=15,UserID=14,Rating=1,Review="Very Poor",IsLike=false},
                new ProductReview(){ProductID=16,UserID=15,Rating=1,Review="Very Poor",IsLike=false},
                new ProductReview(){ProductID=5,UserID=16,Rating=2,Review="Poor",IsLike=true},
                new ProductReview(){ProductID=5,UserID=17,Rating=3,Review="Good",IsLike=true},
                new ProductReview(){ProductID=19,UserID=18,Rating=4,Review="Very good",IsLike=true},
                new ProductReview(){ProductID=20,UserID=19,Rating=5,Review="Excellent",IsLike=true},
                new ProductReview(){ProductID=4,UserID=20,Rating=5,Review="Excellent",IsLike=true},
                new ProductReview(){ProductID=4,UserID=21,Rating=4,Review="Very good",IsLike=true},
                new ProductReview(){ProductID=4,UserID=22,Rating=3,Review="Good",IsLike=true},
                new ProductReview(){ProductID=4,UserID=23,Rating=2,Review="Poor",IsLike=true},
                new ProductReview(){ProductID=4,UserID=24,Rating=1,Review="Very Poor",IsLike=false},
                new ProductReview(){ProductID=10,UserID=25,Rating=1,Review="Very Poor",IsLike=false}

            };

            //foreach( var Records in ProductReviewList)
            //{
            //    Console.WriteLine("{0} {1} {2} {3} {4}", Records.ProductID,Records.UserID,Records.Rating,Records.Review,Records.IsLike);
            //}

            Management management= new Management();
            management.RetireveProductIDReview(ProductReviewList);
        }
    }
}