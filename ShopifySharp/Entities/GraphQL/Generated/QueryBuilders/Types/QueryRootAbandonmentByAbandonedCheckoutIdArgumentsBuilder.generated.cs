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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class QueryRootAbandonmentByAbandonedCheckoutIdArgumentsBuilder : ArgumentsBuilderBase<Abandonment?, QueryRootAbandonmentByAbandonedCheckoutIdArgumentsBuilder>
    {
        protected override QueryRootAbandonmentByAbandonedCheckoutIdArgumentsBuilder Self => this;

        public QueryRootAbandonmentByAbandonedCheckoutIdArgumentsBuilder(IQuery<Abandonment?> query) : base(query)
        {
        }

        public QueryRootAbandonmentByAbandonedCheckoutIdArgumentsBuilder AbandonedCheckoutId(string? abandonedCheckoutId)
        {
            base.InnerQuery.AddArgument("abandonedCheckoutId", abandonedCheckoutId);
            return this;
        }
    }
}