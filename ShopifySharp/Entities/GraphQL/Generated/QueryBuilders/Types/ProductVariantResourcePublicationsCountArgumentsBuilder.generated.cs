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
    public sealed class ProductVariantResourcePublicationsCountArgumentsBuilder : ArgumentsBuilderBase<Count?, ProductVariantResourcePublicationsCountArgumentsBuilder>
    {
        protected override ProductVariantResourcePublicationsCountArgumentsBuilder Self => this;

        public ProductVariantResourcePublicationsCountArgumentsBuilder(IQuery<Count?> query) : base(query)
        {
        }

        public ProductVariantResourcePublicationsCountArgumentsBuilder OnlyPublished(bool? onlyPublished)
        {
            base.InnerQuery.AddArgument("onlyPublished", onlyPublished);
            return this;
        }
    }
}