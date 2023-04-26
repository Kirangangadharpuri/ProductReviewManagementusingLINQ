using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Management
    {
        public void RetiveProductIDAndReview(List<ProductReview> ListOfProductReview)
        {
            var RecordData =from Products in  ListOfProductReview
                             select new { ProductID = Products.ProductID, Review = Products.Review };                            
            foreach (var Record in RecordData)
            {
                Console.WriteLine(Record.ProductID + " " + Record.Review);
            }
        }
    }
}
