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
    public sealed class ProductDeleteMediaPayloadQueryBuilder : FieldsQueryBuilderBase<ProductDeleteMediaPayload, ProductDeleteMediaPayloadQueryBuilder>
    {
        protected override ProductDeleteMediaPayloadQueryBuilder Self => this;

        public ProductDeleteMediaPayloadQueryBuilder() : this("productDeleteMediaPayload")
        {
        }

        public ProductDeleteMediaPayloadQueryBuilder(string name) : base(new Query<ProductDeleteMediaPayload>(name))
        {
        }

        public ProductDeleteMediaPayloadQueryBuilder(IQuery<ProductDeleteMediaPayload> query) : base(query)
        {
        }

        public ProductDeleteMediaPayloadQueryBuilder DeletedMediaIds()
        {
            base.InnerQuery.AddField("deletedMediaIds");
            return this;
        }

        public ProductDeleteMediaPayloadQueryBuilder DeletedProductImageIds()
        {
            base.InnerQuery.AddField("deletedProductImageIds");
            return this;
        }

        public ProductDeleteMediaPayloadQueryBuilder MediaUserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaUserErrorQueryBuilder> build)
        {
            var query = new Query<MediaUserError>("mediaUserErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaUserError>(query);
            return this;
        }

        public ProductDeleteMediaPayloadQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductDeleteMediaPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}