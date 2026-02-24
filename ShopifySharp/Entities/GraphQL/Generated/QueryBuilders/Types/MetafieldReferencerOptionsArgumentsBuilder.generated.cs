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
    public sealed class MetafieldReferencerOptionsArgumentsBuilder : ArgumentsBuilderBase<ProductOption?, MetafieldReferencerOptionsArgumentsBuilder>
    {
        protected override MetafieldReferencerOptionsArgumentsBuilder Self => this;

        public MetafieldReferencerOptionsArgumentsBuilder(IQuery<ProductOption?> query) : base(query)
        {
        }

        public MetafieldReferencerOptionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }
    }
}