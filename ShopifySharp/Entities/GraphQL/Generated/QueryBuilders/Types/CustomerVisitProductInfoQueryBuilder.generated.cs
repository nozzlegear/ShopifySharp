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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class CustomerVisitProductInfoQueryBuilder : FieldsQueryBuilderBase<CustomerVisitProductInfo, CustomerVisitProductInfoQueryBuilder>
    {
        protected override CustomerVisitProductInfoQueryBuilder Self => this;

        public CustomerVisitProductInfoQueryBuilder() : this("customerVisitProductInfo")
        {
        }

        public CustomerVisitProductInfoQueryBuilder(string name) : base(new Query<CustomerVisitProductInfo>(name))
        {
        }

        public CustomerVisitProductInfoQueryBuilder(IQuery<CustomerVisitProductInfo> query) : base(query)
        {
        }

        public CustomerVisitProductInfoQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public CustomerVisitProductInfoQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public CustomerVisitProductInfoQueryBuilder Variant(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("variant");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }
    }
}