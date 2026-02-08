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
    public sealed class ProductChangeStatusArgumentsBuilder : ArgumentsBuilderBase<ProductChangeStatusPayload, ProductChangeStatusArgumentsBuilder>
    {
        protected override ProductChangeStatusArgumentsBuilder Self => this;

        public ProductChangeStatusArgumentsBuilder(IQuery<ProductChangeStatusPayload> query) : base(query)
        {
        }

        public ProductChangeStatusArgumentsBuilder ProductId(string? productId)
        {
            base.InnerQuery.AddArgument("productId", productId);
            return this;
        }

        public ProductChangeStatusArgumentsBuilder Status(ProductStatus? status)
        {
            base.InnerQuery.AddArgument("status", status);
            return this;
        }
    }
}