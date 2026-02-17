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