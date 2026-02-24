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
    public sealed class QueryRootCustomersCountQueryBuilder : FieldsQueryBuilderBase<Count, QueryRootCustomersCountQueryBuilder>, IHasArguments<QueryRootCustomersCountArgumentsBuilder>
    {
        public QueryRootCustomersCountArgumentsBuilder Arguments { get; }
        protected override QueryRootCustomersCountQueryBuilder Self => this;

        public QueryRootCustomersCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new QueryRootCustomersCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCustomersCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new QueryRootCustomersCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCustomersCountQueryBuilder SetArguments(Action<QueryRootCustomersCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCustomersCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootCustomersCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}