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
    public sealed class QueryRootSegmentQueryBuilder : FieldsQueryBuilderBase<Segment, QueryRootSegmentQueryBuilder>, IHasArguments<QueryRootSegmentArgumentsBuilder>
    {
        public QueryRootSegmentArgumentsBuilder Arguments { get; }
        protected override QueryRootSegmentQueryBuilder Self => this;

        public QueryRootSegmentQueryBuilder(string name) : base(new Query<Segment>(name))
        {
            Arguments = new QueryRootSegmentArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSegmentQueryBuilder(IQuery<Segment> query) : base(query)
        {
            Arguments = new QueryRootSegmentArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSegmentQueryBuilder SetArguments(Action<QueryRootSegmentArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootSegmentQueryBuilder CreationDate()
        {
            base.InnerQuery.AddField("creationDate");
            return this;
        }

        public QueryRootSegmentQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootSegmentQueryBuilder LastEditDate()
        {
            base.InnerQuery.AddField("lastEditDate");
            return this;
        }

        public QueryRootSegmentQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public QueryRootSegmentQueryBuilder Query()
        {
            base.InnerQuery.AddField("query");
            return this;
        }
    }
}