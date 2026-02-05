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
    public sealed class ProductVariantsBulkCreateArgumentsBuilder : ArgumentsBuilderBase<ProductVariantsBulkCreatePayload, ProductVariantsBulkCreateArgumentsBuilder>
    {
        protected override ProductVariantsBulkCreateArgumentsBuilder Self => this;

        public ProductVariantsBulkCreateArgumentsBuilder(IQuery<ProductVariantsBulkCreatePayload> query) : base(query)
        {
        }

        public ProductVariantsBulkCreateArgumentsBuilder Media(ICollection<CreateMediaInput>? media)
        {
            base.InnerQuery.AddArgument("media", media);
            return this;
        }

        public ProductVariantsBulkCreateArgumentsBuilder ProductId(string? productId)
        {
            base.InnerQuery.AddArgument("productId", productId);
            return this;
        }

        public ProductVariantsBulkCreateArgumentsBuilder Strategy(ProductVariantsBulkCreateStrategy? strategy)
        {
            base.InnerQuery.AddArgument("strategy", strategy);
            return this;
        }

        public ProductVariantsBulkCreateArgumentsBuilder Variants(ICollection<ProductVariantsBulkInput>? variants)
        {
            base.InnerQuery.AddArgument("variants", variants);
            return this;
        }
    }
}