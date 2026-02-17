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
    public sealed class PublishedProductsCountArgumentsBuilder : ArgumentsBuilderBase<Count, PublishedProductsCountArgumentsBuilder>
    {
        protected override PublishedProductsCountArgumentsBuilder Self => this;

        public PublishedProductsCountArgumentsBuilder(IQuery<Count> query) : base(query)
        {
        }

        public PublishedProductsCountArgumentsBuilder Limit(int? limit)
        {
            base.InnerQuery.AddArgument("limit", limit);
            return this;
        }

        public PublishedProductsCountArgumentsBuilder PublicationId(string? publicationId)
        {
            base.InnerQuery.AddArgument("publicationId", publicationId);
            return this;
        }
    }
}