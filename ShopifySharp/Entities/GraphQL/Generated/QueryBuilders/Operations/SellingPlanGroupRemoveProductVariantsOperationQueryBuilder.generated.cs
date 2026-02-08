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
    public sealed class SellingPlanGroupRemoveProductVariantsOperationQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroupRemoveProductVariantsPayload, SellingPlanGroupRemoveProductVariantsOperationQueryBuilder>, IGraphOperationQueryBuilder<SellingPlanGroupRemoveProductVariantsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SellingPlanGroupRemoveProductVariantsArgumentsBuilder Arguments { get; }
        protected override SellingPlanGroupRemoveProductVariantsOperationQueryBuilder Self => this;

        public SellingPlanGroupRemoveProductVariantsOperationQueryBuilder() : this("sellingPlanGroupRemoveProductVariants")
        {
        }

        public SellingPlanGroupRemoveProductVariantsOperationQueryBuilder(string name) : base(new Query<SellingPlanGroupRemoveProductVariantsPayload>(name))
        {
            Arguments = new SellingPlanGroupRemoveProductVariantsArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupRemoveProductVariantsOperationQueryBuilder(IQuery<SellingPlanGroupRemoveProductVariantsPayload> query) : base(query)
        {
            Arguments = new SellingPlanGroupRemoveProductVariantsArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupRemoveProductVariantsOperationQueryBuilder RemovedProductVariantIds()
        {
            base.InnerQuery.AddField("removedProductVariantIds");
            return this;
        }

        public SellingPlanGroupRemoveProductVariantsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupUserError>(query);
            return this;
        }
    }
}