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
    public sealed class ProductBundleUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<ProductBundleUpdatePayload, ProductBundleUpdatePayloadQueryBuilder>
    {
        protected override ProductBundleUpdatePayloadQueryBuilder Self => this;

        public ProductBundleUpdatePayloadQueryBuilder() : this("productBundleUpdatePayload")
        {
        }

        public ProductBundleUpdatePayloadQueryBuilder(string name) : base(new Query<ProductBundleUpdatePayload>(name))
        {
        }

        public ProductBundleUpdatePayloadQueryBuilder(IQuery<ProductBundleUpdatePayload> query) : base(query)
        {
        }

        public ProductBundleUpdatePayloadQueryBuilder ProductBundleOperation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductBundleOperationQueryBuilder> build)
        {
            var query = new Query<ProductBundleOperation>("productBundleOperation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductBundleOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductBundleOperation>(query);
            return this;
        }

        public ProductBundleUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}