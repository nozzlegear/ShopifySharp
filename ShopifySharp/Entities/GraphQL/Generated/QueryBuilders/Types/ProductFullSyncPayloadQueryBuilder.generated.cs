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
    public sealed class ProductFullSyncPayloadQueryBuilder : FieldsQueryBuilderBase<ProductFullSyncPayload, ProductFullSyncPayloadQueryBuilder>
    {
        protected override ProductFullSyncPayloadQueryBuilder Self => this;

        public ProductFullSyncPayloadQueryBuilder() : this("productFullSyncPayload")
        {
        }

        public ProductFullSyncPayloadQueryBuilder(string name) : base(new Query<ProductFullSyncPayload>(name))
        {
        }

        public ProductFullSyncPayloadQueryBuilder(IQuery<ProductFullSyncPayload> query) : base(query)
        {
        }

        public ProductFullSyncPayloadQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ProductFullSyncPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductFullSyncUserErrorQueryBuilder> build)
        {
            var query = new Query<ProductFullSyncUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductFullSyncUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductFullSyncUserError>(query);
            return this;
        }
    }
}