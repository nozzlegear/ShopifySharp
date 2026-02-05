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
    public sealed class ProductVariantArgumentsBuilder : ArgumentsBuilderBase<ProductVariant, ProductVariantArgumentsBuilder>
    {
        protected override ProductVariantArgumentsBuilder Self => this;

        public ProductVariantArgumentsBuilder(IQuery<ProductVariant> query) : base(query)
        {
        }

        public ProductVariantArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}