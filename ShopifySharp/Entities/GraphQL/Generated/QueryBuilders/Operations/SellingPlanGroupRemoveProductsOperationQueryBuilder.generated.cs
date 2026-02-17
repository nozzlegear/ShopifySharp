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
    public sealed class SellingPlanGroupRemoveProductsOperationQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroupRemoveProductsPayload, SellingPlanGroupRemoveProductsOperationQueryBuilder>, IGraphOperationQueryBuilder<SellingPlanGroupRemoveProductsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SellingPlanGroupRemoveProductsArgumentsBuilder Arguments { get; }
        protected override SellingPlanGroupRemoveProductsOperationQueryBuilder Self => this;

        public SellingPlanGroupRemoveProductsOperationQueryBuilder() : this("sellingPlanGroupRemoveProducts")
        {
        }

        public SellingPlanGroupRemoveProductsOperationQueryBuilder(string name) : base(new Query<SellingPlanGroupRemoveProductsPayload>(name))
        {
            Arguments = new SellingPlanGroupRemoveProductsArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupRemoveProductsOperationQueryBuilder(IQuery<SellingPlanGroupRemoveProductsPayload> query) : base(query)
        {
            Arguments = new SellingPlanGroupRemoveProductsArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupRemoveProductsOperationQueryBuilder RemovedProductIds()
        {
            base.InnerQuery.AddField("removedProductIds");
            return this;
        }

        public SellingPlanGroupRemoveProductsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupUserError>(query);
            return this;
        }
    }
}