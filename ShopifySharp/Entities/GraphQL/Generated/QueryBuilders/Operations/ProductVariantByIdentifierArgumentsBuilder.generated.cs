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
    public sealed class ProductVariantByIdentifierArgumentsBuilder : ArgumentsBuilderBase<ProductVariant, ProductVariantByIdentifierArgumentsBuilder>
    {
        protected override ProductVariantByIdentifierArgumentsBuilder Self => this;

        public ProductVariantByIdentifierArgumentsBuilder(IQuery<ProductVariant> query) : base(query)
        {
        }

        public ProductVariantByIdentifierArgumentsBuilder Identifier(ProductVariantIdentifierInput? identifier)
        {
            base.InnerQuery.AddArgument("identifier", identifier);
            return this;
        }
    }
}