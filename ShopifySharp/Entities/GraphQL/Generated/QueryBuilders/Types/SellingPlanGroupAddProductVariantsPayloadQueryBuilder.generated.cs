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
    public sealed class SellingPlanGroupAddProductVariantsPayloadQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroupAddProductVariantsPayload, SellingPlanGroupAddProductVariantsPayloadQueryBuilder>
    {
        protected override SellingPlanGroupAddProductVariantsPayloadQueryBuilder Self => this;

        public SellingPlanGroupAddProductVariantsPayloadQueryBuilder() : this("sellingPlanGroupAddProductVariantsPayload")
        {
        }

        public SellingPlanGroupAddProductVariantsPayloadQueryBuilder(string name) : base(new Query<SellingPlanGroupAddProductVariantsPayload>(name))
        {
        }

        public SellingPlanGroupAddProductVariantsPayloadQueryBuilder(IQuery<SellingPlanGroupAddProductVariantsPayload> query) : base(query)
        {
        }

        public SellingPlanGroupAddProductVariantsPayloadQueryBuilder SellingPlanGroup(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroup>("sellingPlanGroup");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroup>(query);
            return this;
        }

        public SellingPlanGroupAddProductVariantsPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupUserError>(query);
            return this;
        }
    }
}