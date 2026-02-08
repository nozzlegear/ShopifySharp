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
    public sealed class CollectionReorderProductsArgumentsBuilder : ArgumentsBuilderBase<CollectionReorderProductsPayload, CollectionReorderProductsArgumentsBuilder>
    {
        protected override CollectionReorderProductsArgumentsBuilder Self => this;

        public CollectionReorderProductsArgumentsBuilder(IQuery<CollectionReorderProductsPayload> query) : base(query)
        {
        }

        public CollectionReorderProductsArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public CollectionReorderProductsArgumentsBuilder Moves(ICollection<MoveInput>? moves)
        {
            base.InnerQuery.AddArgument("moves", moves);
            return this;
        }
    }
}