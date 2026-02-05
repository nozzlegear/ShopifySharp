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
    public sealed class ProductOptionsDeletePayloadQueryBuilder : FieldsQueryBuilderBase<ProductOptionsDeletePayload, ProductOptionsDeletePayloadQueryBuilder>
    {
        protected override ProductOptionsDeletePayloadQueryBuilder Self => this;

        public ProductOptionsDeletePayloadQueryBuilder() : this("productOptionsDeletePayload")
        {
        }

        public ProductOptionsDeletePayloadQueryBuilder(string name) : base(new Query<ProductOptionsDeletePayload>(name))
        {
        }

        public ProductOptionsDeletePayloadQueryBuilder(IQuery<ProductOptionsDeletePayload> query) : base(query)
        {
        }

        public ProductOptionsDeletePayloadQueryBuilder DeletedOptionsIds()
        {
            base.InnerQuery.AddField("deletedOptionsIds");
            return this;
        }

        public ProductOptionsDeletePayloadQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductOptionsDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionsDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductOptionsDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionsDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductOptionsDeleteUserError>(query);
            return this;
        }
    }
}