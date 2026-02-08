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