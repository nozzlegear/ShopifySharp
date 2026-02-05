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
    public sealed class AppByHandleArgumentsBuilder : ArgumentsBuilderBase<App, AppByHandleArgumentsBuilder>
    {
        protected override AppByHandleArgumentsBuilder Self => this;

        public AppByHandleArgumentsBuilder(IQuery<App> query) : base(query)
        {
        }

        public AppByHandleArgumentsBuilder Handle(string? handle)
        {
            base.InnerQuery.AddArgument("handle", handle);
            return this;
        }
    }
}