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