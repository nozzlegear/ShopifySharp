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
    public sealed class SubscriptionContractProductChangeArgumentsBuilder : ArgumentsBuilderBase<SubscriptionContractProductChangePayload, SubscriptionContractProductChangeArgumentsBuilder>
    {
        protected override SubscriptionContractProductChangeArgumentsBuilder Self => this;

        public SubscriptionContractProductChangeArgumentsBuilder(IQuery<SubscriptionContractProductChangePayload> query) : base(query)
        {
        }

        public SubscriptionContractProductChangeArgumentsBuilder Input(SubscriptionContractProductChangeInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }

        public SubscriptionContractProductChangeArgumentsBuilder LineId(string? lineId)
        {
            base.InnerQuery.AddArgument("lineId", lineId);
            return this;
        }

        public SubscriptionContractProductChangeArgumentsBuilder SubscriptionContractId(string? subscriptionContractId)
        {
            base.InnerQuery.AddArgument("subscriptionContractId", subscriptionContractId);
            return this;
        }
    }
}