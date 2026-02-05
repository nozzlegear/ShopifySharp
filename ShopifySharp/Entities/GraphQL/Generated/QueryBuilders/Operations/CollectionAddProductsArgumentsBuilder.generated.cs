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
    public sealed class CollectionAddProductsArgumentsBuilder : ArgumentsBuilderBase<CollectionAddProductsPayload, CollectionAddProductsArgumentsBuilder>
    {
        protected override CollectionAddProductsArgumentsBuilder Self => this;

        public CollectionAddProductsArgumentsBuilder(IQuery<CollectionAddProductsPayload> query) : base(query)
        {
        }

        public CollectionAddProductsArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public CollectionAddProductsArgumentsBuilder ProductIds(ICollection<string>? productIds)
        {
            base.InnerQuery.AddArgument("productIds", productIds);
            return this;
        }
    }
}