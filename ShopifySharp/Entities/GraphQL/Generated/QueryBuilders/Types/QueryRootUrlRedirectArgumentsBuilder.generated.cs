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
    public sealed class QueryRootUrlRedirectArgumentsBuilder : ArgumentsBuilderBase<UrlRedirect?, QueryRootUrlRedirectArgumentsBuilder>
    {
        protected override QueryRootUrlRedirectArgumentsBuilder Self => this;

        public QueryRootUrlRedirectArgumentsBuilder(IQuery<UrlRedirect?> query) : base(query)
        {
        }

        public QueryRootUrlRedirectArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}