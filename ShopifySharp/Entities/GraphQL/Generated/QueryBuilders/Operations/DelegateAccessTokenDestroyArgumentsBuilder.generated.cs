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
    public sealed class DelegateAccessTokenDestroyArgumentsBuilder : ArgumentsBuilderBase<DelegateAccessTokenDestroyPayload, DelegateAccessTokenDestroyArgumentsBuilder>
    {
        protected override DelegateAccessTokenDestroyArgumentsBuilder Self => this;

        public DelegateAccessTokenDestroyArgumentsBuilder(IQuery<DelegateAccessTokenDestroyPayload> query) : base(query)
        {
        }

        public DelegateAccessTokenDestroyArgumentsBuilder AccessToken(string? accessToken)
        {
            base.InnerQuery.AddArgument("accessToken", accessToken);
            return this;
        }
    }
}