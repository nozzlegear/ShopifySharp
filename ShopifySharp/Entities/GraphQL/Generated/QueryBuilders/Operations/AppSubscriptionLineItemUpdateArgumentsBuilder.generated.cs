#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class AppSubscriptionLineItemUpdateArgumentsBuilder : ArgumentsBuilderBase<AppSubscriptionLineItemUpdatePayload, AppSubscriptionLineItemUpdateArgumentsBuilder>
    {
        protected override AppSubscriptionLineItemUpdateArgumentsBuilder Self => this;

        public AppSubscriptionLineItemUpdateArgumentsBuilder(IQuery<AppSubscriptionLineItemUpdatePayload> query) : base(query)
        {
        }

        public AppSubscriptionLineItemUpdateArgumentsBuilder CappedAmount(MoneyInput? cappedAmount)
        {
            base.InnerQuery.AddArgument("cappedAmount", cappedAmount);
            return this;
        }

        public AppSubscriptionLineItemUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}