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
    public sealed class QueryRootDraftOrderArgumentsBuilder : ArgumentsBuilderBase<DraftOrder?, QueryRootDraftOrderArgumentsBuilder>
    {
        protected override QueryRootDraftOrderArgumentsBuilder Self => this;

        public QueryRootDraftOrderArgumentsBuilder(IQuery<DraftOrder?> query) : base(query)
        {
        }

        public QueryRootDraftOrderArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}