#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
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

        public JobQueryBuilder Query(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QueryRootQueryBuilder> build)
        {
            var query = new Query<QueryRoot>("query");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QueryRootQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QueryRoot>(query);
            return this;
        }
    }
}