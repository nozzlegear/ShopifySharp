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