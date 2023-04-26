using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Management
    {
        public void SkipTop5Records(List<ProductReview> ListOfProductReview)
        {
            var RecordData =(from Products in  ListOfProductReview
                             select Products).Skip(5);                            
            foreach (var Record in RecordData)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", Record.ProductID, Record.UserID, Record.Rating, Record.Review, Record.IsLike);
            }
        }
    }
}
