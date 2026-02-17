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
    public sealed class ConsentPolicyUpdateArgumentsBuilder : ArgumentsBuilderBase<ConsentPolicyUpdatePayload, ConsentPolicyUpdateArgumentsBuilder>
    {
        protected override ConsentPolicyUpdateArgumentsBuilder Self => this;

        public ConsentPolicyUpdateArgumentsBuilder(IQuery<ConsentPolicyUpdatePayload> query) : base(query)
        {
        }

        public ConsentPolicyUpdateArgumentsBuilder ConsentPolicies(ICollection<ConsentPolicyInput>? consentPolicies)
        {
            base.InnerQuery.AddArgument("consentPolicies", consentPolicies);
            return this;
        }
    }
}