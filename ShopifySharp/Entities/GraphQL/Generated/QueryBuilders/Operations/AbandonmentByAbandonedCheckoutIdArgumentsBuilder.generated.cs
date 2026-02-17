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
    public sealed class AbandonmentByAbandonedCheckoutIdArgumentsBuilder : ArgumentsBuilderBase<Abandonment, AbandonmentByAbandonedCheckoutIdArgumentsBuilder>
    {
        protected override AbandonmentByAbandonedCheckoutIdArgumentsBuilder Self => this;

        public AbandonmentByAbandonedCheckoutIdArgumentsBuilder(IQuery<Abandonment> query) : base(query)
        {
        }

        public AbandonmentByAbandonedCheckoutIdArgumentsBuilder AbandonedCheckoutId(string? abandonedCheckoutId)
        {
            base.InnerQuery.AddArgument("abandonedCheckoutId", abandonedCheckoutId);
            return this;
        }
    }
}