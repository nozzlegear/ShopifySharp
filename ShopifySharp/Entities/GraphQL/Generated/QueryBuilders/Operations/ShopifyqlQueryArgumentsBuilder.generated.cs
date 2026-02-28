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
    public sealed class ShopifyqlQueryArgumentsBuilder : ArgumentsBuilderBase<ShopifyqlQueryResponse, ShopifyqlQueryArgumentsBuilder>
    {
        protected override ShopifyqlQueryArgumentsBuilder Self => this;

        public ShopifyqlQueryArgumentsBuilder(IQuery<ShopifyqlQueryResponse> query) : base(query)
        {
        }

        public ShopifyqlQueryArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }
    }
}