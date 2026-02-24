#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class MetafieldReferencerMerchantRequestsArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderMerchantRequestConnection?, MetafieldReferencerMerchantRequestsArgumentsBuilder>
    {
        protected override MetafieldReferencerMerchantRequestsArgumentsBuilder Self => this;

        public MetafieldReferencerMerchantRequestsArgumentsBuilder(IQuery<FulfillmentOrderMerchantRequestConnection?> query) : base(query)
        {
        }

        public MetafieldReferencerMerchantRequestsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public MetafieldReferencerMerchantRequestsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public MetafieldReferencerMerchantRequestsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MetafieldReferencerMerchantRequestsArgumentsBuilder Kind(FulfillmentOrderMerchantRequestKind? kind)
        {
            base.InnerQuery.AddArgument("kind", kind);
            return this;
        }

        public MetafieldReferencerMerchantRequestsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public MetafieldReferencerMerchantRequestsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}