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