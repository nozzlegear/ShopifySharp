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
    public sealed class SellingPlanGroupAddProductsPayloadQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroupAddProductsPayload, SellingPlanGroupAddProductsPayloadQueryBuilder>
    {
        protected override SellingPlanGroupAddProductsPayloadQueryBuilder Self => this;

        public SellingPlanGroupAddProductsPayloadQueryBuilder() : this("sellingPlanGroupAddProductsPayload")
        {
        }

        public SellingPlanGroupAddProductsPayloadQueryBuilder(string name) : base(new Query<SellingPlanGroupAddProductsPayload>(name))
        {
        }

        public SellingPlanGroupAddProductsPayloadQueryBuilder(IQuery<SellingPlanGroupAddProductsPayload> query) : base(query)
        {
        }

        public SellingPlanGroupAddProductsPayloadQueryBuilder SellingPlanGroup(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroup>("sellingPlanGroup");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroup>(query);
            return this;
        }

        public SellingPlanGroupAddProductsPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupUserError>(query);
            return this;
        }
    }
}