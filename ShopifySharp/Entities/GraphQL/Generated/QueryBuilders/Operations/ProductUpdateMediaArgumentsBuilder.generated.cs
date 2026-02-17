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