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
    public sealed class ProductVariantJoinSellingPlanGroupsOperationQueryBuilder : FieldsQueryBuilderBase<ProductVariantJoinSellingPlanGroupsPayload, ProductVariantJoinSellingPlanGroupsOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductVariantJoinSellingPlanGroupsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductVariantJoinSellingPlanGroupsArgumentsBuilder Arguments { get; }
        protected override ProductVariantJoinSellingPlanGroupsOperationQueryBuilder Self => this;

        public ProductVariantJoinSellingPlanGroupsOperationQueryBuilder() : this("productVariantJoinSellingPlanGroups")
        {
        }

        public ProductVariantJoinSellingPlanGroupsOperationQueryBuilder(string name) : base(new Query<ProductVariantJoinSellingPlanGroupsPayload>(name))
        {
            Arguments = new ProductVariantJoinSellingPlanGroupsArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantJoinSellingPlanGroupsOperationQueryBuilder(IQuery<ProductVariantJoinSellingPlanGroupsPayload> query) : base(query)
        {
            Arguments = new ProductVariantJoinSellingPlanGroupsArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantJoinSellingPlanGroupsOperationQueryBuilder ProductVariant(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("productVariant");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public ProductVariantJoinSellingPlanGroupsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupUserError>(query);
            return this;
        }
    }
}