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
    public sealed class QueryRootEventsCountQueryBuilder : FieldsQueryBuilderBase<Count, QueryRootEventsCountQueryBuilder>, IHasArguments<QueryRootEventsCountArgumentsBuilder>
    {
        public QueryRootEventsCountArgumentsBuilder Arguments { get; }
        protected override QueryRootEventsCountQueryBuilder Self => this;

        public QueryRootEventsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new QueryRootEventsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootEventsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new QueryRootEventsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootEventsCountQueryBuilder SetArguments(Action<QueryRootEventsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootEventsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootEventsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}