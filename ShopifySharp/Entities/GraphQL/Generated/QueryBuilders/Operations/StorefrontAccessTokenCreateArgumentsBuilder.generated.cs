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
    public sealed class StorefrontAccessTokenCreateArgumentsBuilder : ArgumentsBuilderBase<StorefrontAccessTokenCreatePayload, StorefrontAccessTokenCreateArgumentsBuilder>
    {
        protected override StorefrontAccessTokenCreateArgumentsBuilder Self => this;

        public StorefrontAccessTokenCreateArgumentsBuilder(IQuery<StorefrontAccessTokenCreatePayload> query) : base(query)
        {
        }

        public StorefrontAccessTokenCreateArgumentsBuilder Input(StorefrontAccessTokenInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}