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
    public sealed class ProductCreateMediaArgumentsBuilder : ArgumentsBuilderBase<ProductCreateMediaPayload, ProductCreateMediaArgumentsBuilder>
    {
        protected override ProductCreateMediaArgumentsBuilder Self => this;

        public ProductCreateMediaArgumentsBuilder(IQuery<ProductCreateMediaPayload> query) : base(query)
        {
        }

        public ProductCreateMediaArgumentsBuilder Media(ICollection<CreateMediaInput>? media)
        {
            base.InnerQuery.AddArgument("media", media);
            return this;
        }

        public ProductCreateMediaArgumentsBuilder ProductId(string? productId)
        {
            base.InnerQuery.AddArgument("productId", productId);
            return this;
        }
    }
}