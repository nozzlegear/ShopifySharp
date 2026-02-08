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
    public sealed class SellingPlanGroupRemoveProductsPayloadQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroupRemoveProductsPayload, SellingPlanGroupRemoveProductsPayloadQueryBuilder>
    {
        protected override SellingPlanGroupRemoveProductsPayloadQueryBuilder Self => this;

        public SellingPlanGroupRemoveProductsPayloadQueryBuilder() : this("sellingPlanGroupRemoveProductsPayload")
        {
        }

        public SellingPlanGroupRemoveProductsPayloadQueryBuilder(string name) : base(new Query<SellingPlanGroupRemoveProductsPayload>(name))
        {
        }

        public SellingPlanGroupRemoveProductsPayloadQueryBuilder(IQuery<SellingPlanGroupRemoveProductsPayload> query) : base(query)
        {
        }

        public SellingPlanGroupRemoveProductsPayloadQueryBuilder RemovedProductIds()
        {
            base.InnerQuery.AddField("removedProductIds");
            return this;
        }

        public SellingPlanGroupRemoveProductsPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupUserError>(query);
            return this;
        }
    }
}