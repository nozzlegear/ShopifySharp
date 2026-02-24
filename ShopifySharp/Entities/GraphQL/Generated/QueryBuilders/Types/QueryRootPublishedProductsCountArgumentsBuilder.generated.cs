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
    public sealed class QueryRootPublishedProductsCountArgumentsBuilder : ArgumentsBuilderBase<Count?, QueryRootPublishedProductsCountArgumentsBuilder>
    {
        protected override QueryRootPublishedProductsCountArgumentsBuilder Self => this;

        public QueryRootPublishedProductsCountArgumentsBuilder(IQuery<Count?> query) : base(query)
        {
        }

        public QueryRootPublishedProductsCountArgumentsBuilder Limit(int? limit)
        {
            base.InnerQuery.AddArgument("limit", limit);
            return this;
        }

        public QueryRootPublishedProductsCountArgumentsBuilder PublicationId(string? publicationId)
        {
            base.InnerQuery.AddArgument("publicationId", publicationId);
            return this;
        }
    }
}