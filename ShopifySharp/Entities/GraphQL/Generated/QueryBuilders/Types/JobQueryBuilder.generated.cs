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
    public sealed class JobQueryBuilder : FieldsQueryBuilderBase<Job, JobQueryBuilder>
    {
        protected override JobQueryBuilder Self => this;

        public JobQueryBuilder() : this("job")
        {
        }

        public JobQueryBuilder(string name) : base(new Query<Job>(name))
        {
        }

        public JobQueryBuilder(IQuery<Job> query) : base(query)
        {
        }

        public JobQueryBuilder Done()
        {
            base.InnerQuery.AddField("done");
            return this;
        }

        public JobQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public JobQueryBuilder Query(Action<ShopifySharp.GraphQL.QueryBuilders.Types.QueryRootQueryBuilder> build)
        {
            var query = new Query<QueryRoot>("query");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.QueryRootQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QueryRoot>(query);
            return this;
        }
    }
}