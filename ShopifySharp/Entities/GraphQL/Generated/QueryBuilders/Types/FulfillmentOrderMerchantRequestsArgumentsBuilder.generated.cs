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
    public sealed class FulfillmentOrderMerchantRequestsArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderMerchantRequestConnection?, FulfillmentOrderMerchantRequestsArgumentsBuilder>
    {
        protected override FulfillmentOrderMerchantRequestsArgumentsBuilder Self => this;

        public FulfillmentOrderMerchantRequestsArgumentsBuilder(IQuery<FulfillmentOrderMerchantRequestConnection?> query) : base(query)
        {
        }

        public FulfillmentOrderMerchantRequestsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public FulfillmentOrderMerchantRequestsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public FulfillmentOrderMerchantRequestsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public FulfillmentOrderMerchantRequestsArgumentsBuilder Kind(FulfillmentOrderMerchantRequestKind? kind)
        {
            base.InnerQuery.AddArgument("kind", kind);
            return this;
        }

        public FulfillmentOrderMerchantRequestsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public FulfillmentOrderMerchantRequestsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}