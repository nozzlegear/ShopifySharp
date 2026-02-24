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
    public sealed class QueryRootDeletionEventsArgumentsBuilder : ArgumentsBuilderBase<DeletionEventConnection?, QueryRootDeletionEventsArgumentsBuilder>
    {
        protected override QueryRootDeletionEventsArgumentsBuilder Self => this;

        public QueryRootDeletionEventsArgumentsBuilder(IQuery<DeletionEventConnection?> query) : base(query)
        {
        }

        public QueryRootDeletionEventsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootDeletionEventsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootDeletionEventsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootDeletionEventsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootDeletionEventsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public QueryRootDeletionEventsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public QueryRootDeletionEventsArgumentsBuilder SortKey(DeletionEventSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }

        public QueryRootDeletionEventsArgumentsBuilder SubjectTypes(ICollection<DeletionEventSubjectType>? subjectTypes)
        {
            base.InnerQuery.AddArgument("subjectTypes", subjectTypes);
            return this;
        }
    }
}