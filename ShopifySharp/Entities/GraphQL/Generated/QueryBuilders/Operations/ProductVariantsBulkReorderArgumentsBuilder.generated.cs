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