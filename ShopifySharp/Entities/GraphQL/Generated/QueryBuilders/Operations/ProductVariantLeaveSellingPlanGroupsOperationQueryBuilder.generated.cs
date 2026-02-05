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
    public sealed class ProductVariantLeaveSellingPlanGroupsOperationQueryBuilder : FieldsQueryBuilderBase<ProductVariantLeaveSellingPlanGroupsPayload, ProductVariantLeaveSellingPlanGroupsOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductVariantLeaveSellingPlanGroupsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductVariantLeaveSellingPlanGroupsArgumentsBuilder Arguments { get; }
        protected override ProductVariantLeaveSellingPlanGroupsOperationQueryBuilder Self => this;

        public ProductVariantLeaveSellingPlanGroupsOperationQueryBuilder() : this("productVariantLeaveSellingPlanGroups")
        {
        }

        public ProductVariantLeaveSellingPlanGroupsOperationQueryBuilder(string name) : base(new Query<ProductVariantLeaveSellingPlanGroupsPayload>(name))
        {
            Arguments = new ProductVariantLeaveSellingPlanGroupsArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantLeaveSellingPlanGroupsOperationQueryBuilder(IQuery<ProductVariantLeaveSellingPlanGroupsPayload> query) : base(query)
        {
            Arguments = new ProductVariantLeaveSellingPlanGroupsArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantLeaveSellingPlanGroupsOperationQueryBuilder ProductVariant(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("productVariant");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public ProductVariantLeaveSellingPlanGroupsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupUserError>(query);
            return this;
        }
    }
}