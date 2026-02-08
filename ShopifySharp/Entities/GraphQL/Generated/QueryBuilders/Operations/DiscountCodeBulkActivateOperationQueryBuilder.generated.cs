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
    public sealed class DiscountCodeBulkActivateOperationQueryBuilder : FieldsQueryBuilderBase<DiscountCodeBulkActivatePayload, DiscountCodeBulkActivateOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountCodeBulkActivatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountCodeBulkActivateArgumentsBuilder Arguments { get; }
        protected override DiscountCodeBulkActivateOperationQueryBuilder Self => this;

        public DiscountCodeBulkActivateOperationQueryBuilder() : this("discountCodeBulkActivate")
        {
        }

        public DiscountCodeBulkActivateOperationQueryBuilder(string name) : base(new Query<DiscountCodeBulkActivatePayload>(name))
        {
            Arguments = new DiscountCodeBulkActivateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeBulkActivateOperationQueryBuilder(IQuery<DiscountCodeBulkActivatePayload> query) : base(query)
        {
            Arguments = new DiscountCodeBulkActivateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeBulkActivateOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public DiscountCodeBulkActivateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}