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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class QueryRootProductVariantByIdentifierArgumentsBuilder : ArgumentsBuilderBase<ProductVariant?, QueryRootProductVariantByIdentifierArgumentsBuilder>
    {
        protected override QueryRootProductVariantByIdentifierArgumentsBuilder Self => this;

        public QueryRootProductVariantByIdentifierArgumentsBuilder(IQuery<ProductVariant?> query) : base(query)
        {
        }

        public QueryRootProductVariantByIdentifierArgumentsBuilder Identifier(ProductVariantIdentifierInput? identifier)
        {
            base.InnerQuery.AddArgument("identifier", identifier);
            return this;
        }
    }
}