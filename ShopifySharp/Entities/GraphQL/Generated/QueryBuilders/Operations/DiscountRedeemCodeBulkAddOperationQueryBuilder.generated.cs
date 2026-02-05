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
    public sealed class DiscountRedeemCodeBulkAddOperationQueryBuilder : FieldsQueryBuilderBase<DiscountRedeemCodeBulkAddPayload, DiscountRedeemCodeBulkAddOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountRedeemCodeBulkAddPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountRedeemCodeBulkAddArgumentsBuilder Arguments { get; }
        protected override DiscountRedeemCodeBulkAddOperationQueryBuilder Self => this;

        public DiscountRedeemCodeBulkAddOperationQueryBuilder() : this("discountRedeemCodeBulkAdd")
        {
        }

        public DiscountRedeemCodeBulkAddOperationQueryBuilder(string name) : base(new Query<DiscountRedeemCodeBulkAddPayload>(name))
        {
            Arguments = new DiscountRedeemCodeBulkAddArgumentsBuilder(base.InnerQuery);
        }

        public DiscountRedeemCodeBulkAddOperationQueryBuilder(IQuery<DiscountRedeemCodeBulkAddPayload> query) : base(query)
        {
            Arguments = new DiscountRedeemCodeBulkAddArgumentsBuilder(base.InnerQuery);
        }

        public DiscountRedeemCodeBulkAddOperationQueryBuilder BulkCreation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountRedeemCodeBulkCreationQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCodeBulkCreation>("bulkCreation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountRedeemCodeBulkCreationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountRedeemCodeBulkCreation>(query);
            return this;
        }

        public DiscountRedeemCodeBulkAddOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}