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
    public sealed class CollectionDeleteArgumentsBuilder : ArgumentsBuilderBase<CollectionDeletePayload, CollectionDeleteArgumentsBuilder>
    {
        protected override CollectionDeleteArgumentsBuilder Self => this;

        public CollectionDeleteArgumentsBuilder(IQuery<CollectionDeletePayload> query) : base(query)
        {
        }

        public CollectionDeleteArgumentsBuilder Input(CollectionDeleteInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}