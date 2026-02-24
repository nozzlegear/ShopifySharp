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
    public sealed class QueryRootAppInstallationArgumentsBuilder : ArgumentsBuilderBase<AppInstallation?, QueryRootAppInstallationArgumentsBuilder>
    {
        protected override QueryRootAppInstallationArgumentsBuilder Self => this;

        public QueryRootAppInstallationArgumentsBuilder(IQuery<AppInstallation?> query) : base(query)
        {
        }

        public QueryRootAppInstallationArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}