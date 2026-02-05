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

        public DiscountCodeBulkDeactivateOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public DiscountCodeBulkDeactivateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}