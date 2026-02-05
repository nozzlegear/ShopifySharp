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
    public sealed class ProductFeedCreatePayloadQueryBuilder : FieldsQueryBuilderBase<ProductFeedCreatePayload, ProductFeedCreatePayloadQueryBuilder>
    {
        protected override ProductFeedCreatePayloadQueryBuilder Self => this;

        public ProductFeedCreatePayloadQueryBuilder() : this("productFeedCreatePayload")
        {
        }

        public ProductFeedCreatePayloadQueryBuilder(string name) : base(new Query<ProductFeedCreatePayload>(name))
        {
        }

        public ProductFeedCreatePayloadQueryBuilder(IQuery<ProductFeedCreatePayload> query) : base(query)
        {
        }

        public ProductFeedCreatePayloadQueryBuilder ProductFeed(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductFeedQueryBuilder> build)
        {
            var query = new Query<ProductFeed>("productFeed");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductFeedQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductFeed>(query);
            return this;
        }

        public ProductFeedCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductFeedCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductFeedCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductFeedCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductFeedCreateUserError>(query);
            return this;
        }
    }
}