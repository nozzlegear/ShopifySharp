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
    public sealed class CollectionAddProductsV2ArgumentsBuilder : ArgumentsBuilderBase<CollectionAddProductsV2Payload, CollectionAddProductsV2ArgumentsBuilder>
    {
        protected override CollectionAddProductsV2ArgumentsBuilder Self => this;

        public CollectionAddProductsV2ArgumentsBuilder(IQuery<CollectionAddProductsV2Payload> query) : base(query)
        {
        }

        public CollectionAddProductsV2ArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public CollectionAddProductsV2ArgumentsBuilder ProductIds(ICollection<string>? productIds)
        {
            base.InnerQuery.AddArgument("productIds", productIds);
            return this;
        }
    }
}