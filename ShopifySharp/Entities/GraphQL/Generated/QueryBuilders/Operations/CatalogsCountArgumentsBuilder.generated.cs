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
    public sealed class CatalogsCountArgumentsBuilder : ArgumentsBuilderBase<Count, CatalogsCountArgumentsBuilder>
    {
        protected override CatalogsCountArgumentsBuilder Self => this;

        public CatalogsCountArgumentsBuilder(IQuery<Count> query) : base(query)
        {
        }

        public CatalogsCountArgumentsBuilder Limit(int? limit)
        {
            base.InnerQuery.AddArgument("limit", limit);
            return this;
        }

        public CatalogsCountArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public CatalogsCountArgumentsBuilder Type(CatalogType? type)
        {
            base.InnerQuery.AddArgument("type", type);
            return this;
        }
    }
}