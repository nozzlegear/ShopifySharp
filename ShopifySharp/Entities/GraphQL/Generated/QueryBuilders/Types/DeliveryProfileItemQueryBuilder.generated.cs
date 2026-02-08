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
    public sealed class DeliveryProfileItemQueryBuilder : FieldsQueryBuilderBase<DeliveryProfileItem, DeliveryProfileItemQueryBuilder>
    {
        protected override DeliveryProfileItemQueryBuilder Self => this;

        public DeliveryProfileItemQueryBuilder() : this("deliveryProfileItem")
        {
        }

        public DeliveryProfileItemQueryBuilder(string name) : base(new Query<DeliveryProfileItem>(name))
        {
        }

        public DeliveryProfileItemQueryBuilder(IQuery<DeliveryProfileItem> query) : base(query)
        {
        }

        public DeliveryProfileItemQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryProfileItemQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public DeliveryProfileItemQueryBuilder Variants(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantConnection>("variants");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantConnection>(query);
            return this;
        }
    }
}