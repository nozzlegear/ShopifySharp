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
    public sealed class QueryRootCollectionByHandleArgumentsBuilder : ArgumentsBuilderBase<Collection?, QueryRootCollectionByHandleArgumentsBuilder>
    {
        protected override QueryRootCollectionByHandleArgumentsBuilder Self => this;

        public QueryRootCollectionByHandleArgumentsBuilder(IQuery<Collection?> query) : base(query)
        {
        }

        public QueryRootCollectionByHandleArgumentsBuilder Handle(string? handle)
        {
            base.InnerQuery.AddArgument("handle", handle);
            return this;
        }
    }
}