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
    public sealed class QueryRootShopifyFunctionArgumentsBuilder : ArgumentsBuilderBase<ShopifyFunction?, QueryRootShopifyFunctionArgumentsBuilder>
    {
        protected override QueryRootShopifyFunctionArgumentsBuilder Self => this;

        public QueryRootShopifyFunctionArgumentsBuilder(IQuery<ShopifyFunction?> query) : base(query)
        {
        }

        public QueryRootShopifyFunctionArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}