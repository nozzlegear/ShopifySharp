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
    public sealed class UrlRedirectBulkDeleteBySearchArgumentsBuilder : ArgumentsBuilderBase<UrlRedirectBulkDeleteBySearchPayload, UrlRedirectBulkDeleteBySearchArgumentsBuilder>
    {
        protected override UrlRedirectBulkDeleteBySearchArgumentsBuilder Self => this;

        public UrlRedirectBulkDeleteBySearchArgumentsBuilder(IQuery<UrlRedirectBulkDeleteBySearchPayload> query) : base(query)
        {
        }

        public UrlRedirectBulkDeleteBySearchArgumentsBuilder Search(string? search)
        {
            base.InnerQuery.AddArgument("search", search);
            return this;
        }
    }
}