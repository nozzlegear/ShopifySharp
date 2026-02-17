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
    public sealed class CollectionByHandleArgumentsBuilder : ArgumentsBuilderBase<Collection, CollectionByHandleArgumentsBuilder>
    {
        protected override CollectionByHandleArgumentsBuilder Self => this;

        public CollectionByHandleArgumentsBuilder(IQuery<Collection> query) : base(query)
        {
        }

        public CollectionByHandleArgumentsBuilder Handle(string? handle)
        {
            base.InnerQuery.AddArgument("handle", handle);
            return this;
        }
    }
}