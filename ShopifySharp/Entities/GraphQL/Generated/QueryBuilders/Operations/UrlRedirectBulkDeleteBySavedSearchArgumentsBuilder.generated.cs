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
    public sealed class UrlRedirectBulkDeleteBySavedSearchArgumentsBuilder : ArgumentsBuilderBase<UrlRedirectBulkDeleteBySavedSearchPayload, UrlRedirectBulkDeleteBySavedSearchArgumentsBuilder>
    {
        protected override UrlRedirectBulkDeleteBySavedSearchArgumentsBuilder Self => this;

        public UrlRedirectBulkDeleteBySavedSearchArgumentsBuilder(IQuery<UrlRedirectBulkDeleteBySavedSearchPayload> query) : base(query)
        {
        }

        public UrlRedirectBulkDeleteBySavedSearchArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }
    }
}