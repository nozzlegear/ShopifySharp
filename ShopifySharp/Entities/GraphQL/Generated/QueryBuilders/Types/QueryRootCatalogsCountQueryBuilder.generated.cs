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
    public sealed class QueryRootCatalogsCountQueryBuilder : FieldsQueryBuilderBase<Count, QueryRootCatalogsCountQueryBuilder>, IHasArguments<QueryRootCatalogsCountArgumentsBuilder>
    {
        public QueryRootCatalogsCountArgumentsBuilder Arguments { get; }
        protected override QueryRootCatalogsCountQueryBuilder Self => this;

        public QueryRootCatalogsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new QueryRootCatalogsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCatalogsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new QueryRootCatalogsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCatalogsCountQueryBuilder SetArguments(Action<QueryRootCatalogsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCatalogsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootCatalogsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}