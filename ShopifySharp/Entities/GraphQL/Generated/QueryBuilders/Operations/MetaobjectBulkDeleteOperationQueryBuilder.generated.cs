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
    public sealed class MetaobjectBulkDeleteOperationQueryBuilder : FieldsQueryBuilderBase<MetaobjectBulkDeletePayload, MetaobjectBulkDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<MetaobjectBulkDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MetaobjectBulkDeleteArgumentsBuilder Arguments { get; }
        protected override MetaobjectBulkDeleteOperationQueryBuilder Self => this;

        public MetaobjectBulkDeleteOperationQueryBuilder() : this("metaobjectBulkDelete")
        {
        }

        public MetaobjectBulkDeleteOperationQueryBuilder(string name) : base(new Query<MetaobjectBulkDeletePayload>(name))
        {
            Arguments = new MetaobjectBulkDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectBulkDeleteOperationQueryBuilder(IQuery<MetaobjectBulkDeletePayload> query) : base(query)
        {
            Arguments = new MetaobjectBulkDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MetaobjectBulkDeleteOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public MetaobjectBulkDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder> build)
        {
            var query = new Query<MetaobjectUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetaobjectUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetaobjectUserError>(query);
            return this;
        }
    }
}