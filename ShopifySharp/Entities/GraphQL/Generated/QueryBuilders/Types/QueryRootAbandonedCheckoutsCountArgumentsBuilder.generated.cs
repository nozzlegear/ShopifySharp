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
    public sealed class QueryRootAbandonedCheckoutsCountArgumentsBuilder : ArgumentsBuilderBase<Count?, QueryRootAbandonedCheckoutsCountArgumentsBuilder>
    {
        protected override QueryRootAbandonedCheckoutsCountArgumentsBuilder Self => this;

        public QueryRootAbandonedCheckoutsCountArgumentsBuilder(IQuery<Count?> query) : base(query)
        {
        }

        public QueryRootAbandonedCheckoutsCountArgumentsBuilder Limit(int? limit)
        {
            base.InnerQuery.AddArgument("limit", limit);
            return this;
        }

        public QueryRootAbandonedCheckoutsCountArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public QueryRootAbandonedCheckoutsCountArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }
    }
}