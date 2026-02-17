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
    public sealed class SellingPlanGroupAddProductVariantsOperationQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroupAddProductVariantsPayload, SellingPlanGroupAddProductVariantsOperationQueryBuilder>, IGraphOperationQueryBuilder<SellingPlanGroupAddProductVariantsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SellingPlanGroupAddProductVariantsArgumentsBuilder Arguments { get; }
        protected override SellingPlanGroupAddProductVariantsOperationQueryBuilder Self => this;

        public SellingPlanGroupAddProductVariantsOperationQueryBuilder() : this("sellingPlanGroupAddProductVariants")
        {
        }

        public SellingPlanGroupAddProductVariantsOperationQueryBuilder(string name) : base(new Query<SellingPlanGroupAddProductVariantsPayload>(name))
        {
            Arguments = new SellingPlanGroupAddProductVariantsArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupAddProductVariantsOperationQueryBuilder(IQuery<SellingPlanGroupAddProductVariantsPayload> query) : base(query)
        {
            Arguments = new SellingPlanGroupAddProductVariantsArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupAddProductVariantsOperationQueryBuilder SellingPlanGroup(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroup>("sellingPlanGroup");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroup>(query);
            return this;
        }

        public SellingPlanGroupAddProductVariantsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupUserError>(query);
            return this;
        }
    }
}