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
    public sealed class OrderStagedChangeAddVariantQueryBuilder : FieldsQueryBuilderBase<OrderStagedChangeAddVariant, OrderStagedChangeAddVariantQueryBuilder>
    {
        protected override OrderStagedChangeAddVariantQueryBuilder Self => this;

        public OrderStagedChangeAddVariantQueryBuilder() : this("orderStagedChangeAddVariant")
        {
        }

        public OrderStagedChangeAddVariantQueryBuilder(string name) : base(new Query<OrderStagedChangeAddVariant>(name))
        {
        }

        public OrderStagedChangeAddVariantQueryBuilder(IQuery<OrderStagedChangeAddVariant> query) : base(query)
        {
        }

        public OrderStagedChangeAddVariantQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public OrderStagedChangeAddVariantQueryBuilder Variant(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("variant");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }
    }
}