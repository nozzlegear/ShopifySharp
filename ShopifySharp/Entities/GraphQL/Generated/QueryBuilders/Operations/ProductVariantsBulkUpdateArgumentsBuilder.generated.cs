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
    public sealed class ProductVariantsBulkUpdateArgumentsBuilder : ArgumentsBuilderBase<ProductVariantsBulkUpdatePayload, ProductVariantsBulkUpdateArgumentsBuilder>
    {
        protected override ProductVariantsBulkUpdateArgumentsBuilder Self => this;

        public ProductVariantsBulkUpdateArgumentsBuilder(IQuery<ProductVariantsBulkUpdatePayload> query) : base(query)
        {
        }

        public ProductVariantsBulkUpdateArgumentsBuilder AllowPartialUpdates(bool? allowPartialUpdates)
        {
            base.InnerQuery.AddArgument("allowPartialUpdates", allowPartialUpdates);
            return this;
        }

        public ProductVariantsBulkUpdateArgumentsBuilder Media(ICollection<CreateMediaInput>? media)
        {
            base.InnerQuery.AddArgument("media", media);
            return this;
        }

        public ProductVariantsBulkUpdateArgumentsBuilder ProductId(string? productId)
        {
            base.InnerQuery.AddArgument("productId", productId);
            return this;
        }

        public ProductVariantsBulkUpdateArgumentsBuilder Variants(ICollection<ProductVariantsBulkInput>? variants)
        {
            base.InnerQuery.AddArgument("variants", variants);
            return this;
        }
    }
}