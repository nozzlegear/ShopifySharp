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
    public sealed class QueryRootPagesCountQueryBuilder : FieldsQueryBuilderBase<Count, QueryRootPagesCountQueryBuilder>, IHasArguments<QueryRootPagesCountArgumentsBuilder>
    {
        public QueryRootPagesCountArgumentsBuilder Arguments { get; }
        protected override QueryRootPagesCountQueryBuilder Self => this;

        public QueryRootPagesCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new QueryRootPagesCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootPagesCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new QueryRootPagesCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootPagesCountQueryBuilder SetArguments(Action<QueryRootPagesCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootPagesCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootPagesCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}