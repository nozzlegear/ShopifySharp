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
    public sealed class ProductVariantAppendMediaArgumentsBuilder : ArgumentsBuilderBase<ProductVariantAppendMediaPayload, ProductVariantAppendMediaArgumentsBuilder>
    {
        protected override ProductVariantAppendMediaArgumentsBuilder Self => this;

        public ProductVariantAppendMediaArgumentsBuilder(IQuery<ProductVariantAppendMediaPayload> query) : base(query)
        {
        }

        public ProductVariantAppendMediaArgumentsBuilder ProductId(string? productId)
        {
            base.InnerQuery.AddArgument("productId", productId);
            return this;
        }

        public ProductVariantAppendMediaArgumentsBuilder VariantMedia(ICollection<ProductVariantAppendMediaInput>? variantMedia)
        {
            base.InnerQuery.AddArgument("variantMedia", variantMedia);
            return this;
        }
    }
}