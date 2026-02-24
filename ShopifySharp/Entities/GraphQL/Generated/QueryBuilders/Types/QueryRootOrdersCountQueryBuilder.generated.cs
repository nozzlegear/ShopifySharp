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
    public sealed class QueryRootOrdersCountQueryBuilder : FieldsQueryBuilderBase<Count, QueryRootOrdersCountQueryBuilder>, IHasArguments<QueryRootOrdersCountArgumentsBuilder>
    {
        public QueryRootOrdersCountArgumentsBuilder Arguments { get; }
        protected override QueryRootOrdersCountQueryBuilder Self => this;

        public QueryRootOrdersCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new QueryRootOrdersCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootOrdersCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new QueryRootOrdersCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootOrdersCountQueryBuilder SetArguments(Action<QueryRootOrdersCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootOrdersCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootOrdersCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}