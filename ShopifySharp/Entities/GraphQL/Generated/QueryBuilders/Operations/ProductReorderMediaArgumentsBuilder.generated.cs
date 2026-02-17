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
    public sealed class ProductReorderMediaArgumentsBuilder : ArgumentsBuilderBase<ProductReorderMediaPayload, ProductReorderMediaArgumentsBuilder>
    {
        protected override ProductReorderMediaArgumentsBuilder Self => this;

        public ProductReorderMediaArgumentsBuilder(IQuery<ProductReorderMediaPayload> query) : base(query)
        {
        }

        public ProductReorderMediaArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public ProductReorderMediaArgumentsBuilder Moves(ICollection<MoveInput>? moves)
        {
            base.InnerQuery.AddArgument("moves", moves);
            return this;
        }
    }
}