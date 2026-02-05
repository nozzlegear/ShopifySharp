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
    public sealed class ProductUpdateMediaArgumentsBuilder : ArgumentsBuilderBase<ProductUpdateMediaPayload, ProductUpdateMediaArgumentsBuilder>
    {
        protected override ProductUpdateMediaArgumentsBuilder Self => this;

        public ProductUpdateMediaArgumentsBuilder(IQuery<ProductUpdateMediaPayload> query) : base(query)
        {
        }

        public ProductUpdateMediaArgumentsBuilder Media(ICollection<UpdateMediaInput>? media)
        {
            base.InnerQuery.AddArgument("media", media);
            return this;
        }

        public ProductUpdateMediaArgumentsBuilder ProductId(string? productId)
        {
            base.InnerQuery.AddArgument("productId", productId);
            return this;
        }
    }
}