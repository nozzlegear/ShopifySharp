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
    public sealed class AppRevokeAccessScopesArgumentsBuilder : ArgumentsBuilderBase<AppRevokeAccessScopesPayload, AppRevokeAccessScopesArgumentsBuilder>
    {
        protected override AppRevokeAccessScopesArgumentsBuilder Self => this;

        public AppRevokeAccessScopesArgumentsBuilder(IQuery<AppRevokeAccessScopesPayload> query) : base(query)
        {
        }

        public AppRevokeAccessScopesArgumentsBuilder Scopes(ICollection<string>? scopes)
        {
            base.InnerQuery.AddArgument("scopes", scopes);
            return this;
        }
    }
}