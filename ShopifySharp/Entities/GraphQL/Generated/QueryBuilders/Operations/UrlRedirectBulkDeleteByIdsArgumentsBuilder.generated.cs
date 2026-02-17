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
    public sealed class UrlRedirectBulkDeleteByIdsArgumentsBuilder : ArgumentsBuilderBase<UrlRedirectBulkDeleteByIdsPayload, UrlRedirectBulkDeleteByIdsArgumentsBuilder>
    {
        protected override UrlRedirectBulkDeleteByIdsArgumentsBuilder Self => this;

        public UrlRedirectBulkDeleteByIdsArgumentsBuilder(IQuery<UrlRedirectBulkDeleteByIdsPayload> query) : base(query)
        {
        }

        public UrlRedirectBulkDeleteByIdsArgumentsBuilder Ids(ICollection<string>? ids)
        {
            base.InnerQuery.AddArgument("ids", ids);
            return this;
        }
    }
}