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
    public sealed class ProductDuplicateArgumentsBuilder : ArgumentsBuilderBase<ProductDuplicatePayload, ProductDuplicateArgumentsBuilder>
    {
        protected override ProductDuplicateArgumentsBuilder Self => this;

        public ProductDuplicateArgumentsBuilder(IQuery<ProductDuplicatePayload> query) : base(query)
        {
        }

        public ProductDuplicateArgumentsBuilder IncludeImages(bool? includeImages)
        {
            base.InnerQuery.AddArgument("includeImages", includeImages);
            return this;
        }

        public ProductDuplicateArgumentsBuilder IncludeTranslations(bool? includeTranslations)
        {
            base.InnerQuery.AddArgument("includeTranslations", includeTranslations);
            return this;
        }

        public ProductDuplicateArgumentsBuilder NewStatus(ProductStatus? newStatus)
        {
            base.InnerQuery.AddArgument("newStatus", newStatus);
            return this;
        }

        public ProductDuplicateArgumentsBuilder NewTitle(string? newTitle)
        {
            base.InnerQuery.AddArgument("newTitle", newTitle);
            return this;
        }

        public ProductDuplicateArgumentsBuilder ProductId(string? productId)
        {
            base.InnerQuery.AddArgument("productId", productId);
            return this;
        }

        public ProductDuplicateArgumentsBuilder Synchronous(bool? synchronous)
        {
            base.InnerQuery.AddArgument("synchronous", synchronous);
            return this;
        }
    }
}