#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class PublicationsCountArgumentsBuilder : ArgumentsBuilderBase<Count, PublicationsCountArgumentsBuilder>
    {
        protected override PublicationsCountArgumentsBuilder Self => this;

        public PublicationsCountArgumentsBuilder(IQuery<Count> query) : base(query)
        {
        }

        public PublicationsCountArgumentsBuilder CatalogType(CatalogType? catalogType)
        {
            base.InnerQuery.AddArgument("catalogType", catalogType);
            return this;
        }

        public PublicationsCountArgumentsBuilder Limit(int? limit)
        {
            base.InnerQuery.AddArgument("limit", limit);
            return this;
        }
    }
}