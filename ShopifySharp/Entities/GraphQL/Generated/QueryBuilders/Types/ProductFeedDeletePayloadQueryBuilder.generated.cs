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
    public sealed class ProductFeedDeletePayloadQueryBuilder : FieldsQueryBuilderBase<ProductFeedDeletePayload, ProductFeedDeletePayloadQueryBuilder>
    {
        protected override ProductFeedDeletePayloadQueryBuilder Self => this;

        public ProductFeedDeletePayloadQueryBuilder() : this("productFeedDeletePayload")
        {
        }

        public ProductFeedDeletePayloadQueryBuilder(string name) : base(new Query<ProductFeedDeletePayload>(name))
        {
        }

        public ProductFeedDeletePayloadQueryBuilder(IQuery<ProductFeedDeletePayload> query) : base(query)
        {
        }

        public ProductFeedDeletePayloadQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public ProductFeedDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductFeedDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductFeedDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductFeedDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductFeedDeleteUserError>(query);
            return this;
        }
    }
}