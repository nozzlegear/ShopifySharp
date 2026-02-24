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
    public sealed class QueryRootFulfillmentArgumentsBuilder : ArgumentsBuilderBase<Fulfillment?, QueryRootFulfillmentArgumentsBuilder>
    {
        protected override QueryRootFulfillmentArgumentsBuilder Self => this;

        public QueryRootFulfillmentArgumentsBuilder(IQuery<Fulfillment?> query) : base(query)
        {
        }

        public QueryRootFulfillmentArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}