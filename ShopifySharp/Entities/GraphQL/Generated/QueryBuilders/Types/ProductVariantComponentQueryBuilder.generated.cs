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
    public sealed class ProductVariantComponentQueryBuilder : FieldsQueryBuilderBase<ProductVariantComponent, ProductVariantComponentQueryBuilder>
    {
        protected override ProductVariantComponentQueryBuilder Self => this;

        public ProductVariantComponentQueryBuilder() : this("productVariantComponent")
        {
        }

        public ProductVariantComponentQueryBuilder(string name) : base(new Query<ProductVariantComponent>(name))
        {
        }

        public ProductVariantComponentQueryBuilder(IQuery<ProductVariantComponent> query) : base(query)
        {
        }

        public ProductVariantComponentQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ProductVariantComponentQueryBuilder ProductVariant(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("productVariant");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public ProductVariantComponentQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }
    }
}