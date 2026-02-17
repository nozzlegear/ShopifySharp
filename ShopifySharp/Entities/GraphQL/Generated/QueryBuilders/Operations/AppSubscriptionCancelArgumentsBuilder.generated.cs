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
    public sealed class AppSubscriptionCancelArgumentsBuilder : ArgumentsBuilderBase<AppSubscriptionCancelPayload, AppSubscriptionCancelArgumentsBuilder>
    {
        protected override AppSubscriptionCancelArgumentsBuilder Self => this;

        public AppSubscriptionCancelArgumentsBuilder(IQuery<AppSubscriptionCancelPayload> query) : base(query)
        {
        }

        public AppSubscriptionCancelArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public AppSubscriptionCancelArgumentsBuilder Prorate(bool? prorate)
        {
            base.InnerQuery.AddArgument("prorate", prorate);
            return this;
        }
    }
}