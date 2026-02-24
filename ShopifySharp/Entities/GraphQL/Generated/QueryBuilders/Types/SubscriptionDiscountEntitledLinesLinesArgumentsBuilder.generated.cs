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
    public sealed class SubscriptionDiscountEntitledLinesLinesArgumentsBuilder : ArgumentsBuilderBase<SubscriptionLineConnection?, SubscriptionDiscountEntitledLinesLinesArgumentsBuilder>
    {
        protected override SubscriptionDiscountEntitledLinesLinesArgumentsBuilder Self => this;

        public SubscriptionDiscountEntitledLinesLinesArgumentsBuilder(IQuery<SubscriptionLineConnection?> query) : base(query)
        {
        }

        public SubscriptionDiscountEntitledLinesLinesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public SubscriptionDiscountEntitledLinesLinesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public SubscriptionDiscountEntitledLinesLinesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public SubscriptionDiscountEntitledLinesLinesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public SubscriptionDiscountEntitledLinesLinesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}