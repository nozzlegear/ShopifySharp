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