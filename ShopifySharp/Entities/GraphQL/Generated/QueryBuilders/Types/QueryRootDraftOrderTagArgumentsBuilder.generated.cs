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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class QueryRootDraftOrderTagArgumentsBuilder : ArgumentsBuilderBase<DraftOrderTag?, QueryRootDraftOrderTagArgumentsBuilder>
    {
        protected override QueryRootDraftOrderTagArgumentsBuilder Self => this;

        public QueryRootDraftOrderTagArgumentsBuilder(IQuery<DraftOrderTag?> query) : base(query)
        {
        }

        public QueryRootDraftOrderTagArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}