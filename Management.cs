using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Management
    {
        public void SelectRecords(List<ProductReview> ListOfProductReview)
        {
            var RecordData = from Products in ListOfProductReview
                             where (Products.ProductID==1 || Products.ProductID == 7 || Products.ProductID == 9)
                             && Products.Rating > 3
                             select Products;
            foreach (var Record in RecordData)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", Record.ProductID, Record.UserID, Record.Rating, Record.Review, Record.IsLike);
            }
        }
    }
}
