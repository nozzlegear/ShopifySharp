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
    public sealed class ShopPolicyUpdateArgumentsBuilder : ArgumentsBuilderBase<ShopPolicyUpdatePayload, ShopPolicyUpdateArgumentsBuilder>
    {
        protected override ShopPolicyUpdateArgumentsBuilder Self => this;

        public ShopPolicyUpdateArgumentsBuilder(IQuery<ShopPolicyUpdatePayload> query) : base(query)
        {
        }

        public ShopPolicyUpdateArgumentsBuilder ShopPolicy(ShopPolicyInput? shopPolicy)
        {
            base.InnerQuery.AddArgument("shopPolicy", shopPolicy);
            return this;
        }
    }
}