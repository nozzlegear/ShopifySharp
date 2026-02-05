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
    public sealed class UrlRedirectDeleteArgumentsBuilder : ArgumentsBuilderBase<UrlRedirectDeletePayload, UrlRedirectDeleteArgumentsBuilder>
    {
        protected override UrlRedirectDeleteArgumentsBuilder Self => this;

        public UrlRedirectDeleteArgumentsBuilder(IQuery<UrlRedirectDeletePayload> query) : base(query)
        {
        }

        public UrlRedirectDeleteArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}