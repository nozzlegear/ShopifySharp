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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class SellingPlanGroupRemoveProductVariantsPayloadQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroupRemoveProductVariantsPayload, SellingPlanGroupRemoveProductVariantsPayloadQueryBuilder>
    {
        protected override SellingPlanGroupRemoveProductVariantsPayloadQueryBuilder Self => this;

        public SellingPlanGroupRemoveProductVariantsPayloadQueryBuilder() : this("sellingPlanGroupRemoveProductVariantsPayload")
        {
        }

        public SellingPlanGroupRemoveProductVariantsPayloadQueryBuilder(string name) : base(new Query<SellingPlanGroupRemoveProductVariantsPayload>(name))
        {
        }

        public SellingPlanGroupRemoveProductVariantsPayloadQueryBuilder(IQuery<SellingPlanGroupRemoveProductVariantsPayload> query) : base(query)
        {
        }

        public SellingPlanGroupRemoveProductVariantsPayloadQueryBuilder RemovedProductVariantIds()
        {
            base.InnerQuery.AddField("removedProductVariantIds");
            return this;
        }

        public SellingPlanGroupRemoveProductVariantsPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupUserError>(query);
            return this;
        }
    }
}