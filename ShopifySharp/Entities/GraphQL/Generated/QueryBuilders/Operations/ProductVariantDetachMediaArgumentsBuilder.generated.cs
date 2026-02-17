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
    public sealed class ProductVariantDetachMediaArgumentsBuilder : ArgumentsBuilderBase<ProductVariantDetachMediaPayload, ProductVariantDetachMediaArgumentsBuilder>
    {
        protected override ProductVariantDetachMediaArgumentsBuilder Self => this;

        public ProductVariantDetachMediaArgumentsBuilder(IQuery<ProductVariantDetachMediaPayload> query) : base(query)
        {
        }

        public ProductVariantDetachMediaArgumentsBuilder ProductId(string? productId)
        {
            base.InnerQuery.AddArgument("productId", productId);
            return this;
        }

        public ProductVariantDetachMediaArgumentsBuilder VariantMedia(ICollection<ProductVariantDetachMediaInput>? variantMedia)
        {
            base.InnerQuery.AddArgument("variantMedia", variantMedia);
            return this;
        }
    }
}