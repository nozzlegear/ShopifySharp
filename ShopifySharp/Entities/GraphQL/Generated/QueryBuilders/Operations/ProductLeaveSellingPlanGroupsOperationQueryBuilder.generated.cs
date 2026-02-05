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
    public sealed class ProductLeaveSellingPlanGroupsOperationQueryBuilder : FieldsQueryBuilderBase<ProductLeaveSellingPlanGroupsPayload, ProductLeaveSellingPlanGroupsOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductLeaveSellingPlanGroupsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductLeaveSellingPlanGroupsArgumentsBuilder Arguments { get; }
        protected override ProductLeaveSellingPlanGroupsOperationQueryBuilder Self => this;

        public ProductLeaveSellingPlanGroupsOperationQueryBuilder() : this("productLeaveSellingPlanGroups")
        {
        }

        public ProductLeaveSellingPlanGroupsOperationQueryBuilder(string name) : base(new Query<ProductLeaveSellingPlanGroupsPayload>(name))
        {
            Arguments = new ProductLeaveSellingPlanGroupsArgumentsBuilder(base.InnerQuery);
        }

        public ProductLeaveSellingPlanGroupsOperationQueryBuilder(IQuery<ProductLeaveSellingPlanGroupsPayload> query) : base(query)
        {
            Arguments = new ProductLeaveSellingPlanGroupsArgumentsBuilder(base.InnerQuery);
        }

        public ProductLeaveSellingPlanGroupsOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductLeaveSellingPlanGroupsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupUserError>(query);
            return this;
        }
    }
}