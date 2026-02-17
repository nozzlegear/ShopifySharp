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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class DiscountCodeBulkDeactivateOperationQueryBuilder : FieldsQueryBuilderBase<DiscountCodeBulkDeactivatePayload, DiscountCodeBulkDeactivateOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountCodeBulkDeactivatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountCodeBulkDeactivateArgumentsBuilder Arguments { get; }
        protected override DiscountCodeBulkDeactivateOperationQueryBuilder Self => this;

        public DiscountCodeBulkDeactivateOperationQueryBuilder() : this("discountCodeBulkDeactivate")
        {
        }

        public DiscountCodeBulkDeactivateOperationQueryBuilder(string name) : base(new Query<DiscountCodeBulkDeactivatePayload>(name))
        {
            Arguments = new DiscountCodeBulkDeactivateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeBulkDeactivateOperationQueryBuilder(IQuery<DiscountCodeBulkDeactivatePayload> query) : base(query)
        {
            Arguments = new DiscountCodeBulkDeactivateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeBulkDeactivateOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public DiscountCodeBulkDeactivateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}