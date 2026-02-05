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
    public sealed class ProductVariantLeaveSellingPlanGroupsPayloadQueryBuilder : FieldsQueryBuilderBase<ProductVariantLeaveSellingPlanGroupsPayload, ProductVariantLeaveSellingPlanGroupsPayloadQueryBuilder>
    {
        protected override ProductVariantLeaveSellingPlanGroupsPayloadQueryBuilder Self => this;

        public ProductVariantLeaveSellingPlanGroupsPayloadQueryBuilder() : this("productVariantLeaveSellingPlanGroupsPayload")
        {
        }

        public ProductVariantLeaveSellingPlanGroupsPayloadQueryBuilder(string name) : base(new Query<ProductVariantLeaveSellingPlanGroupsPayload>(name))
        {
        }

        public ProductVariantLeaveSellingPlanGroupsPayloadQueryBuilder(IQuery<ProductVariantLeaveSellingPlanGroupsPayload> query) : base(query)
        {
        }

        public ProductVariantLeaveSellingPlanGroupsPayloadQueryBuilder ProductVariant(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("productVariant");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public ProductVariantLeaveSellingPlanGroupsPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupUserError>(query);
            return this;
        }
    }
}