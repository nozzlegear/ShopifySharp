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
    public sealed class DiscountCodeBulkDeleteOperationQueryBuilder : FieldsQueryBuilderBase<DiscountCodeBulkDeletePayload, DiscountCodeBulkDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountCodeBulkDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountCodeBulkDeleteArgumentsBuilder Arguments { get; }
        protected override DiscountCodeBulkDeleteOperationQueryBuilder Self => this;

        public DiscountCodeBulkDeleteOperationQueryBuilder() : this("discountCodeBulkDelete")
        {
        }

        public DiscountCodeBulkDeleteOperationQueryBuilder(string name) : base(new Query<DiscountCodeBulkDeletePayload>(name))
        {
            Arguments = new DiscountCodeBulkDeleteArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeBulkDeleteOperationQueryBuilder(IQuery<DiscountCodeBulkDeletePayload> query) : base(query)
        {
            Arguments = new DiscountCodeBulkDeleteArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeBulkDeleteOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public DiscountCodeBulkDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}