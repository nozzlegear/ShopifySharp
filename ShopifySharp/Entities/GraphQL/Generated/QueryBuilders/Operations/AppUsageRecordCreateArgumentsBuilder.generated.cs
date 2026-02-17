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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class AppUsageRecordCreateArgumentsBuilder : ArgumentsBuilderBase<AppUsageRecordCreatePayload, AppUsageRecordCreateArgumentsBuilder>
    {
        protected override AppUsageRecordCreateArgumentsBuilder Self => this;

        public AppUsageRecordCreateArgumentsBuilder(IQuery<AppUsageRecordCreatePayload> query) : base(query)
        {
        }

        public AppUsageRecordCreateArgumentsBuilder Description(string? description)
        {
            base.InnerQuery.AddArgument("description", description);
            return this;
        }

        public AppUsageRecordCreateArgumentsBuilder IdempotencyKey(string? idempotencyKey)
        {
            base.InnerQuery.AddArgument("idempotencyKey", idempotencyKey);
            return this;
        }

        public AppUsageRecordCreateArgumentsBuilder Price(MoneyInput? price)
        {
            base.InnerQuery.AddArgument("price", price);
            return this;
        }

        public AppUsageRecordCreateArgumentsBuilder SubscriptionLineItemId(string? subscriptionLineItemId)
        {
            base.InnerQuery.AddArgument("subscriptionLineItemId", subscriptionLineItemId);
            return this;
        }
    }
}