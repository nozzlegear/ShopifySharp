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
    public sealed class SubscriptionContractCreateArgumentsBuilder : ArgumentsBuilderBase<SubscriptionContractCreatePayload, SubscriptionContractCreateArgumentsBuilder>
    {
        protected override SubscriptionContractCreateArgumentsBuilder Self => this;

        public SubscriptionContractCreateArgumentsBuilder(IQuery<SubscriptionContractCreatePayload> query) : base(query)
        {
        }

        public SubscriptionContractCreateArgumentsBuilder Input(SubscriptionContractCreateInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}