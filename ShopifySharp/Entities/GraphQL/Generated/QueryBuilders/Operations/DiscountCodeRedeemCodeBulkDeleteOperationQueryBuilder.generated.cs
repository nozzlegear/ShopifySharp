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
    public sealed class DiscountCodeRedeemCodeBulkDeleteOperationQueryBuilder : FieldsQueryBuilderBase<DiscountCodeRedeemCodeBulkDeletePayload, DiscountCodeRedeemCodeBulkDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountCodeRedeemCodeBulkDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountCodeRedeemCodeBulkDeleteArgumentsBuilder Arguments { get; }
        protected override DiscountCodeRedeemCodeBulkDeleteOperationQueryBuilder Self => this;

        public DiscountCodeRedeemCodeBulkDeleteOperationQueryBuilder() : this("discountCodeRedeemCodeBulkDelete")
        {
        }

        public DiscountCodeRedeemCodeBulkDeleteOperationQueryBuilder(string name) : base(new Query<DiscountCodeRedeemCodeBulkDeletePayload>(name))
        {
            Arguments = new DiscountCodeRedeemCodeBulkDeleteArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeRedeemCodeBulkDeleteOperationQueryBuilder(IQuery<DiscountCodeRedeemCodeBulkDeletePayload> query) : base(query)
        {
            Arguments = new DiscountCodeRedeemCodeBulkDeleteArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeRedeemCodeBulkDeleteOperationQueryBuilder Job(Action<ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public DiscountCodeRedeemCodeBulkDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}