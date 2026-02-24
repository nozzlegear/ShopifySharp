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
    public sealed class AppArgumentsBuilder : ArgumentsBuilderBase<App, AppArgumentsBuilder>
    {
        protected override AppArgumentsBuilder Self => this;

        public AppArgumentsBuilder(IQuery<App> query) : base(query)
        {
        }

        public AppArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public AppArgumentsBuilder Handle(string? handle)
        {
            base.InnerQuery.AddArgument("handle", handle);
            return this;
        }

        public AppArgumentsBuilder ApiKey(string? apiKey)
        {
            base.InnerQuery.AddArgument("apiKey", apiKey);
            return this;
        }
    }
}