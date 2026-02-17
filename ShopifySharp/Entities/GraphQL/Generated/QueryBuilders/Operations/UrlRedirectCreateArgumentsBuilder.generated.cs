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
    public sealed class UrlRedirectCreateArgumentsBuilder : ArgumentsBuilderBase<UrlRedirectCreatePayload, UrlRedirectCreateArgumentsBuilder>
    {
        protected override UrlRedirectCreateArgumentsBuilder Self => this;

        public UrlRedirectCreateArgumentsBuilder(IQuery<UrlRedirectCreatePayload> query) : base(query)
        {
        }

        public UrlRedirectCreateArgumentsBuilder UrlRedirect(UrlRedirectInput? urlRedirect)
        {
            base.InnerQuery.AddArgument("urlRedirect", urlRedirect);
            return this;
        }
    }
}