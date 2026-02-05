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
    public sealed class ProductChangeStatusPayloadQueryBuilder : FieldsQueryBuilderBase<ProductChangeStatusPayload, ProductChangeStatusPayloadQueryBuilder>
    {
        protected override ProductChangeStatusPayloadQueryBuilder Self => this;

        public ProductChangeStatusPayloadQueryBuilder() : this("productChangeStatusPayload")
        {
        }

        public ProductChangeStatusPayloadQueryBuilder(string name) : base(new Query<ProductChangeStatusPayload>(name))
        {
        }

        public ProductChangeStatusPayloadQueryBuilder(IQuery<ProductChangeStatusPayload> query) : base(query)
        {
        }

        public ProductChangeStatusPayloadQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductChangeStatusPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductChangeStatusUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductChangeStatusUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductChangeStatusUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductChangeStatusUserError>(query);
            return this;
        }
    }
}