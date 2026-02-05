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
    public sealed class SubscriptionContractUpdateArgumentsBuilder : ArgumentsBuilderBase<SubscriptionContractUpdatePayload, SubscriptionContractUpdateArgumentsBuilder>
    {
        protected override SubscriptionContractUpdateArgumentsBuilder Self => this;

        public SubscriptionContractUpdateArgumentsBuilder(IQuery<SubscriptionContractUpdatePayload> query) : base(query)
        {
        }

        public SubscriptionContractUpdateArgumentsBuilder ContractId(string? contractId)
        {
            base.InnerQuery.AddArgument("contractId", contractId);
            return this;
        }
    }
}