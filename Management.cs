using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Management
    {
        public void RetiveCountOfRecords(List<ProductReview> ListOfProductReview)
        {
            var RecordData = ListOfProductReview.
                            GroupBy(x => x.ProductID).
                             Select(x => new { ProductID = x.Key, count = x.Count() });                            
            foreach (var Record in RecordData)
            {
                Console.WriteLine("For ProductID = {0} the records are {1}", Record.ProductID, Record.count);
            }
        }
    }
}
