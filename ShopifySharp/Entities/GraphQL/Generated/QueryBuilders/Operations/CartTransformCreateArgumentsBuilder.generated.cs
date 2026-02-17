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
    public sealed class CartTransformCreateArgumentsBuilder : ArgumentsBuilderBase<CartTransformCreatePayload, CartTransformCreateArgumentsBuilder>
    {
        protected override CartTransformCreateArgumentsBuilder Self => this;

        public CartTransformCreateArgumentsBuilder(IQuery<CartTransformCreatePayload> query) : base(query)
        {
        }

        public CartTransformCreateArgumentsBuilder BlockOnFailure(bool? blockOnFailure)
        {
            base.InnerQuery.AddArgument("blockOnFailure", blockOnFailure);
            return this;
        }

        public CartTransformCreateArgumentsBuilder FunctionHandle(string? functionHandle)
        {
            base.InnerQuery.AddArgument("functionHandle", functionHandle);
            return this;
        }

        public CartTransformCreateArgumentsBuilder Metafields(ICollection<MetafieldInput>? metafields)
        {
            base.InnerQuery.AddArgument("metafields", metafields);
            return this;
        }
    }
}