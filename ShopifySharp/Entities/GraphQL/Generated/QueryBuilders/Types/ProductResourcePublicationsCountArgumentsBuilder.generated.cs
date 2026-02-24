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
    public sealed class ProductResourcePublicationsCountArgumentsBuilder : ArgumentsBuilderBase<Count?, ProductResourcePublicationsCountArgumentsBuilder>
    {
        protected override ProductResourcePublicationsCountArgumentsBuilder Self => this;

        public ProductResourcePublicationsCountArgumentsBuilder(IQuery<Count?> query) : base(query)
        {
        }

        public ProductResourcePublicationsCountArgumentsBuilder OnlyPublished(bool? onlyPublished)
        {
            base.InnerQuery.AddArgument("onlyPublished", onlyPublished);
            return this;
        }
    }
}