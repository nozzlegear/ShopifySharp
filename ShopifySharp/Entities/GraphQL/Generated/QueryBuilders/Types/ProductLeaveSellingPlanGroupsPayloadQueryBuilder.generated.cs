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
    public sealed class ProductLeaveSellingPlanGroupsPayloadQueryBuilder : FieldsQueryBuilderBase<ProductLeaveSellingPlanGroupsPayload, ProductLeaveSellingPlanGroupsPayloadQueryBuilder>
    {
        protected override ProductLeaveSellingPlanGroupsPayloadQueryBuilder Self => this;

        public ProductLeaveSellingPlanGroupsPayloadQueryBuilder() : this("productLeaveSellingPlanGroupsPayload")
        {
        }

        public ProductLeaveSellingPlanGroupsPayloadQueryBuilder(string name) : base(new Query<ProductLeaveSellingPlanGroupsPayload>(name))
        {
        }

        public ProductLeaveSellingPlanGroupsPayloadQueryBuilder(IQuery<ProductLeaveSellingPlanGroupsPayload> query) : base(query)
        {
        }

        public ProductLeaveSellingPlanGroupsPayloadQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductLeaveSellingPlanGroupsPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupUserError>(query);
            return this;
        }
    }
}