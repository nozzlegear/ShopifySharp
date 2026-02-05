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
    public sealed class ProductJoinSellingPlanGroupsPayloadQueryBuilder : FieldsQueryBuilderBase<ProductJoinSellingPlanGroupsPayload, ProductJoinSellingPlanGroupsPayloadQueryBuilder>
    {
        protected override ProductJoinSellingPlanGroupsPayloadQueryBuilder Self => this;

        public ProductJoinSellingPlanGroupsPayloadQueryBuilder() : this("productJoinSellingPlanGroupsPayload")
        {
        }

        public ProductJoinSellingPlanGroupsPayloadQueryBuilder(string name) : base(new Query<ProductJoinSellingPlanGroupsPayload>(name))
        {
        }

        public ProductJoinSellingPlanGroupsPayloadQueryBuilder(IQuery<ProductJoinSellingPlanGroupsPayload> query) : base(query)
        {
        }

        public ProductJoinSellingPlanGroupsPayloadQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductJoinSellingPlanGroupsPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupUserError>(query);
            return this;
        }
    }
}