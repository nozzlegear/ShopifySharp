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
    public sealed class ProductOptionsCreateArgumentsBuilder : ArgumentsBuilderBase<ProductOptionsCreatePayload, ProductOptionsCreateArgumentsBuilder>
    {
        protected override ProductOptionsCreateArgumentsBuilder Self => this;

        public ProductOptionsCreateArgumentsBuilder(IQuery<ProductOptionsCreatePayload> query) : base(query)
        {
        }

        public ProductOptionsCreateArgumentsBuilder Options(ICollection<OptionCreateInput>? options)
        {
            base.InnerQuery.AddArgument("options", options);
            return this;
        }

        public ProductOptionsCreateArgumentsBuilder ProductId(string? productId)
        {
            base.InnerQuery.AddArgument("productId", productId);
            return this;
        }

        public ProductOptionsCreateArgumentsBuilder VariantStrategy(ProductOptionCreateVariantStrategy? variantStrategy)
        {
            base.InnerQuery.AddArgument("variantStrategy", variantStrategy);
            return this;
        }
    }
}