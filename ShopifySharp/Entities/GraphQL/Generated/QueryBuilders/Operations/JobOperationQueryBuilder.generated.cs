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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class JobOperationQueryBuilder : FieldsQueryBuilderBase<Job, JobOperationQueryBuilder>, IGraphOperationQueryBuilder<Job>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public JobArgumentsBuilder Arguments { get; }
        protected override JobOperationQueryBuilder Self => this;

        public JobOperationQueryBuilder() : this("job")
        {
        }

        public JobOperationQueryBuilder(string name) : base(new Query<Job>(name))
        {
            Arguments = new JobArgumentsBuilder(base.InnerQuery);
        }

        public JobOperationQueryBuilder(IQuery<Job> query) : base(query)
        {
            Arguments = new JobArgumentsBuilder(base.InnerQuery);
        }

        public JobOperationQueryBuilder Done()
        {
            base.InnerQuery.AddField("done");
            return this;
        }

        public JobOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public JobOperationQueryBuilder Query(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QueryRootQueryBuilder> build)
        {
            var query = new Query<QueryRoot>("query");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QueryRootQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QueryRoot>(query);
            return this;
        }
    }
}