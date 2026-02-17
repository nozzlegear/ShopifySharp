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
    public sealed class ProductVariantsBulkReorderArgumentsBuilder : ArgumentsBuilderBase<ProductVariantsBulkReorderPayload, ProductVariantsBulkReorderArgumentsBuilder>
    {
        protected override ProductVariantsBulkReorderArgumentsBuilder Self => this;

        public ProductVariantsBulkReorderArgumentsBuilder(IQuery<ProductVariantsBulkReorderPayload> query) : base(query)
        {
        }

        public ProductVariantsBulkReorderArgumentsBuilder Positions(ICollection<ProductVariantPositionInput>? positions)
        {
            base.InnerQuery.AddArgument("positions", positions);
            return this;
        }

        public ProductVariantsBulkReorderArgumentsBuilder ProductId(string? productId)
        {
            base.InnerQuery.AddArgument("productId", productId);
            return this;
        }
    }
}