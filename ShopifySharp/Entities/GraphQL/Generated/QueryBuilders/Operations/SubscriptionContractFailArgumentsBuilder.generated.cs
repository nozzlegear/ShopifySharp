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
    public sealed class SubscriptionContractFailArgumentsBuilder : ArgumentsBuilderBase<SubscriptionContractFailPayload, SubscriptionContractFailArgumentsBuilder>
    {
        protected override SubscriptionContractFailArgumentsBuilder Self => this;

        public SubscriptionContractFailArgumentsBuilder(IQuery<SubscriptionContractFailPayload> query) : base(query)
        {
        }

        public SubscriptionContractFailArgumentsBuilder SubscriptionContractId(string? subscriptionContractId)
        {
            base.InnerQuery.AddArgument("subscriptionContractId", subscriptionContractId);
            return this;
        }
    }
}