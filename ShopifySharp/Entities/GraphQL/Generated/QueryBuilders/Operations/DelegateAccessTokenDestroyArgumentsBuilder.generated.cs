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