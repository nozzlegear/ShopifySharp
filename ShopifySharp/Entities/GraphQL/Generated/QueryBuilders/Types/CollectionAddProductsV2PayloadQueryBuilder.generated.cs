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
    public sealed class CollectionAddProductsV2PayloadQueryBuilder : FieldsQueryBuilderBase<CollectionAddProductsV2Payload, CollectionAddProductsV2PayloadQueryBuilder>
    {
        protected override CollectionAddProductsV2PayloadQueryBuilder Self => this;

        public CollectionAddProductsV2PayloadQueryBuilder() : this("collectionAddProductsV2Payload")
        {
        }

        public CollectionAddProductsV2PayloadQueryBuilder(string name) : base(new Query<CollectionAddProductsV2Payload>(name))
        {
        }

        public CollectionAddProductsV2PayloadQueryBuilder(IQuery<CollectionAddProductsV2Payload> query) : base(query)
        {
        }

        public CollectionAddProductsV2PayloadQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public CollectionAddProductsV2PayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionAddProductsV2UserErrorQueryBuilder> build)
        {
            var query = new Query<CollectionAddProductsV2UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionAddProductsV2UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionAddProductsV2UserError>(query);
            return this;
        }
    }
}