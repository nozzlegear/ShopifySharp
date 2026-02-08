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
    public sealed class ProductCreateMediaPayloadQueryBuilder : FieldsQueryBuilderBase<ProductCreateMediaPayload, ProductCreateMediaPayloadQueryBuilder>
    {
        protected override ProductCreateMediaPayloadQueryBuilder Self => this;

        public ProductCreateMediaPayloadQueryBuilder() : this("productCreateMediaPayload")
        {
        }

        public ProductCreateMediaPayloadQueryBuilder(string name) : base(new Query<ProductCreateMediaPayload>(name))
        {
        }

        public ProductCreateMediaPayloadQueryBuilder(IQuery<ProductCreateMediaPayload> query) : base(query)
        {
        }

        public ProductCreateMediaPayloadQueryBuilder Media(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaQueryBuilder> build)
        {
            var query = new Query<IMedia>("media");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IMedia>(query);
            return this;
        }

        public ProductCreateMediaPayloadQueryBuilder MediaUserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaUserErrorQueryBuilder> build)
        {
            var query = new Query<MediaUserError>("mediaUserErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaUserError>(query);
            return this;
        }

        public ProductCreateMediaPayloadQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductCreateMediaPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}