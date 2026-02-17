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
    public sealed class ProductJoinSellingPlanGroupsOperationQueryBuilder : FieldsQueryBuilderBase<ProductJoinSellingPlanGroupsPayload, ProductJoinSellingPlanGroupsOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductJoinSellingPlanGroupsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ProductJoinSellingPlanGroupsArgumentsBuilder Arguments { get; }
        protected override ProductJoinSellingPlanGroupsOperationQueryBuilder Self => this;

        public ProductJoinSellingPlanGroupsOperationQueryBuilder() : this("productJoinSellingPlanGroups")
        {
        }

        public ProductJoinSellingPlanGroupsOperationQueryBuilder(string name) : base(new Query<ProductJoinSellingPlanGroupsPayload>(name))
        {
            Arguments = new ProductJoinSellingPlanGroupsArgumentsBuilder(base.InnerQuery);
        }

        public ProductJoinSellingPlanGroupsOperationQueryBuilder(IQuery<ProductJoinSellingPlanGroupsPayload> query) : base(query)
        {
            Arguments = new ProductJoinSellingPlanGroupsArgumentsBuilder(base.InnerQuery);
        }

        public ProductJoinSellingPlanGroupsOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductJoinSellingPlanGroupsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupUserError>(query);
            return this;
        }
    }
}