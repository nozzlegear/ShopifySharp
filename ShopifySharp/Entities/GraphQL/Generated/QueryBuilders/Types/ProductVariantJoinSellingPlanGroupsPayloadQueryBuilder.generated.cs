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
    public sealed class ProductVariantJoinSellingPlanGroupsPayloadQueryBuilder : FieldsQueryBuilderBase<ProductVariantJoinSellingPlanGroupsPayload, ProductVariantJoinSellingPlanGroupsPayloadQueryBuilder>
    {
        protected override ProductVariantJoinSellingPlanGroupsPayloadQueryBuilder Self => this;

        public ProductVariantJoinSellingPlanGroupsPayloadQueryBuilder() : this("productVariantJoinSellingPlanGroupsPayload")
        {
        }

        public ProductVariantJoinSellingPlanGroupsPayloadQueryBuilder(string name) : base(new Query<ProductVariantJoinSellingPlanGroupsPayload>(name))
        {
        }

        public ProductVariantJoinSellingPlanGroupsPayloadQueryBuilder(IQuery<ProductVariantJoinSellingPlanGroupsPayload> query) : base(query)
        {
        }

        public ProductVariantJoinSellingPlanGroupsPayloadQueryBuilder ProductVariant(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("productVariant");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public ProductVariantJoinSellingPlanGroupsPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupUserError>(query);
            return this;
        }
    }
}