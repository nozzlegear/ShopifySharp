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
    public sealed class ProductVariantsBulkDeleteArgumentsBuilder : ArgumentsBuilderBase<ProductVariantsBulkDeletePayload, ProductVariantsBulkDeleteArgumentsBuilder>
    {
        protected override ProductVariantsBulkDeleteArgumentsBuilder Self => this;

        public ProductVariantsBulkDeleteArgumentsBuilder(IQuery<ProductVariantsBulkDeletePayload> query) : base(query)
        {
        }

        public ProductVariantsBulkDeleteArgumentsBuilder ProductId(string? productId)
        {
            base.InnerQuery.AddArgument("productId", productId);
            return this;
        }

        public ProductVariantsBulkDeleteArgumentsBuilder VariantsIds(ICollection<string>? variantsIds)
        {
            base.InnerQuery.AddArgument("variantsIds", variantsIds);
            return this;
        }
    }
}