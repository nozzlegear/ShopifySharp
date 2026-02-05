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
    public sealed class UrlRedirectImportArgumentsBuilder : ArgumentsBuilderBase<UrlRedirectImport, UrlRedirectImportArgumentsBuilder>
    {
        protected override UrlRedirectImportArgumentsBuilder Self => this;

        public UrlRedirectImportArgumentsBuilder(IQuery<UrlRedirectImport> query) : base(query)
        {
        }

        public UrlRedirectImportArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}