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
    public sealed class CollectionRemoveProductsArgumentsBuilder : ArgumentsBuilderBase<CollectionRemoveProductsPayload, CollectionRemoveProductsArgumentsBuilder>
    {
        protected override CollectionRemoveProductsArgumentsBuilder Self => this;

        public CollectionRemoveProductsArgumentsBuilder(IQuery<CollectionRemoveProductsPayload> query) : base(query)
        {
        }

        public CollectionRemoveProductsArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public CollectionRemoveProductsArgumentsBuilder ProductIds(ICollection<string>? productIds)
        {
            base.InnerQuery.AddArgument("productIds", productIds);
            return this;
        }
    }
}