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
    public sealed class QueryRootJobQueryBuilder : FieldsQueryBuilderBase<Job, QueryRootJobQueryBuilder>, IHasArguments<QueryRootJobArgumentsBuilder>
    {
        public QueryRootJobArgumentsBuilder Arguments { get; }
        protected override QueryRootJobQueryBuilder Self => this;

        public QueryRootJobQueryBuilder(string name) : base(new Query<Job>(name))
        {
            Arguments = new QueryRootJobArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootJobQueryBuilder(IQuery<Job> query) : base(query)
        {
            Arguments = new QueryRootJobArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootJobQueryBuilder SetArguments(Action<QueryRootJobArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootJobQueryBuilder Done()
        {
            base.InnerQuery.AddField("done");
            return this;
        }

        public QueryRootJobQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootJobQueryBuilder Query(Action<ShopifySharp.GraphQL.QueryBuilders.Types.QueryRootQueryBuilder> build)
        {
            var query = new Query<QueryRoot>("query");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.QueryRootQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QueryRoot>(query);
            return this;
        }
    }
}