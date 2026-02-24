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
    public sealed class QueryRootBlogsCountQueryBuilder : FieldsQueryBuilderBase<Count, QueryRootBlogsCountQueryBuilder>, IHasArguments<QueryRootBlogsCountArgumentsBuilder>
    {
        public QueryRootBlogsCountArgumentsBuilder Arguments { get; }
        protected override QueryRootBlogsCountQueryBuilder Self => this;

        public QueryRootBlogsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new QueryRootBlogsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootBlogsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new QueryRootBlogsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootBlogsCountQueryBuilder SetArguments(Action<QueryRootBlogsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootBlogsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootBlogsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}