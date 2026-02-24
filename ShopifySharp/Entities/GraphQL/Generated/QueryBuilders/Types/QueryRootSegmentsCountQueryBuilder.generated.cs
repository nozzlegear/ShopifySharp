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
    public sealed class QueryRootSegmentsCountQueryBuilder : FieldsQueryBuilderBase<Count, QueryRootSegmentsCountQueryBuilder>, IHasArguments<QueryRootSegmentsCountArgumentsBuilder>
    {
        public QueryRootSegmentsCountArgumentsBuilder Arguments { get; }
        protected override QueryRootSegmentsCountQueryBuilder Self => this;

        public QueryRootSegmentsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new QueryRootSegmentsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSegmentsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new QueryRootSegmentsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSegmentsCountQueryBuilder SetArguments(Action<QueryRootSegmentsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootSegmentsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootSegmentsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}