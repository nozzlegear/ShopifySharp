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
    public sealed class ProductDeleteMediaArgumentsBuilder : ArgumentsBuilderBase<ProductDeleteMediaPayload, ProductDeleteMediaArgumentsBuilder>
    {
        protected override ProductDeleteMediaArgumentsBuilder Self => this;

        public ProductDeleteMediaArgumentsBuilder(IQuery<ProductDeleteMediaPayload> query) : base(query)
        {
        }

        public ProductDeleteMediaArgumentsBuilder MediaIds(ICollection<string>? mediaIds)
        {
            base.InnerQuery.AddArgument("mediaIds", mediaIds);
            return this;
        }

        public ProductDeleteMediaArgumentsBuilder ProductId(string? productId)
        {
            base.InnerQuery.AddArgument("productId", productId);
            return this;
        }
    }
}