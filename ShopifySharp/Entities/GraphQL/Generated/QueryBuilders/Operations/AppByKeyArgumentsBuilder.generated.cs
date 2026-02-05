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
    public sealed class AppByKeyArgumentsBuilder : ArgumentsBuilderBase<App, AppByKeyArgumentsBuilder>
    {
        protected override AppByKeyArgumentsBuilder Self => this;

        public AppByKeyArgumentsBuilder(IQuery<App> query) : base(query)
        {
        }

        public AppByKeyArgumentsBuilder ApiKey(string? apiKey)
        {
            base.InnerQuery.AddArgument("apiKey", apiKey);
            return this;
        }
    }
}