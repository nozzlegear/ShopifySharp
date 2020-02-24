using System.Collections.Generic;

namespace ShopifySharp.Filters
{
    public class ApplicationCreditListFilter : ListFilter<ApplicationCredit>
    {
        public string Fields { get; set; }

        public override IEnumerable<KeyValuePair<string, object>> ToQueryParameters()
        {
            return base.ToQueryParameters();
        }
    }
}