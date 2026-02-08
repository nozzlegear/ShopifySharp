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
    public sealed class UrlRedirectImportCreateArgumentsBuilder : ArgumentsBuilderBase<UrlRedirectImportCreatePayload, UrlRedirectImportCreateArgumentsBuilder>
    {
        protected override UrlRedirectImportCreateArgumentsBuilder Self => this;

        public UrlRedirectImportCreateArgumentsBuilder(IQuery<UrlRedirectImportCreatePayload> query) : base(query)
        {
        }

        public UrlRedirectImportCreateArgumentsBuilder Url(string? url)
        {
            base.InnerQuery.AddArgument("url", url);
            return this;
        }
    }
}