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