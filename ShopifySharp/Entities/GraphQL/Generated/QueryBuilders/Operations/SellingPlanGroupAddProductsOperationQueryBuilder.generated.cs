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
    public sealed class SellingPlanGroupAddProductsOperationQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroupAddProductsPayload, SellingPlanGroupAddProductsOperationQueryBuilder>, IGraphOperationQueryBuilder<SellingPlanGroupAddProductsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SellingPlanGroupAddProductsArgumentsBuilder Arguments { get; }
        protected override SellingPlanGroupAddProductsOperationQueryBuilder Self => this;

        public SellingPlanGroupAddProductsOperationQueryBuilder() : this("sellingPlanGroupAddProducts")
        {
        }

        public SellingPlanGroupAddProductsOperationQueryBuilder(string name) : base(new Query<SellingPlanGroupAddProductsPayload>(name))
        {
            Arguments = new SellingPlanGroupAddProductsArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupAddProductsOperationQueryBuilder(IQuery<SellingPlanGroupAddProductsPayload> query) : base(query)
        {
            Arguments = new SellingPlanGroupAddProductsArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupAddProductsOperationQueryBuilder SellingPlanGroup(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroup>("sellingPlanGroup");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroup>(query);
            return this;
        }

        public SellingPlanGroupAddProductsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupUserError>(query);
            return this;
        }
    }
}