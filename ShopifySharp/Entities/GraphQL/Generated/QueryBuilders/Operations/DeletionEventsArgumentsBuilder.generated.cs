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
    public sealed class DeletionEventsArgumentsBuilder : ArgumentsBuilderBase<DeletionEventConnection, DeletionEventsArgumentsBuilder>
    {
        protected override DeletionEventsArgumentsBuilder Self => this;

        public DeletionEventsArgumentsBuilder(IQuery<DeletionEventConnection> query) : base(query)
        {
        }

        public DeletionEventsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public DeletionEventsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public DeletionEventsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public DeletionEventsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public DeletionEventsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public DeletionEventsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public DeletionEventsArgumentsBuilder SortKey(DeletionEventSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }

        public DeletionEventsArgumentsBuilder SubjectTypes(ICollection<DeletionEventSubjectType>? subjectTypes)
        {
            base.InnerQuery.AddArgument("subjectTypes", subjectTypes);
            return this;
        }
    }
}