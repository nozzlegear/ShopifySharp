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
    public sealed class PublicationIncludedProductsCountArgumentsBuilder : ArgumentsBuilderBase<Count?, PublicationIncludedProductsCountArgumentsBuilder>
    {
        protected override PublicationIncludedProductsCountArgumentsBuilder Self => this;

        public PublicationIncludedProductsCountArgumentsBuilder(IQuery<Count?> query) : base(query)
        {
        }

        public PublicationIncludedProductsCountArgumentsBuilder Limit(int? limit)
        {
            base.InnerQuery.AddArgument("limit", limit);
            return this;
        }

        public PublicationIncludedProductsCountArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public PublicationIncludedProductsCountArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }
    }
}