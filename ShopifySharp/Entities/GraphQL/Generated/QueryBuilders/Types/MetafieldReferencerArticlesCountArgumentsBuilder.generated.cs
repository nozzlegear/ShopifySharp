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
    public sealed class MetafieldReferencerArticlesCountArgumentsBuilder : ArgumentsBuilderBase<Count?, MetafieldReferencerArticlesCountArgumentsBuilder>
    {
        protected override MetafieldReferencerArticlesCountArgumentsBuilder Self => this;

        public MetafieldReferencerArticlesCountArgumentsBuilder(IQuery<Count?> query) : base(query)
        {
        }

        public MetafieldReferencerArticlesCountArgumentsBuilder Limit(int? limit)
        {
            base.InnerQuery.AddArgument("limit", limit);
            return this;
        }
    }
}