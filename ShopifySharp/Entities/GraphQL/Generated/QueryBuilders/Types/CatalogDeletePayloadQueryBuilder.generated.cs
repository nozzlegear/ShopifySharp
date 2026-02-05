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
    public sealed class CatalogDeletePayloadQueryBuilder : FieldsQueryBuilderBase<CatalogDeletePayload, CatalogDeletePayloadQueryBuilder>
    {
        protected override CatalogDeletePayloadQueryBuilder Self => this;

        public CatalogDeletePayloadQueryBuilder() : this("catalogDeletePayload")
        {
        }

        public CatalogDeletePayloadQueryBuilder(string name) : base(new Query<CatalogDeletePayload>(name))
        {
        }

        public CatalogDeletePayloadQueryBuilder(IQuery<CatalogDeletePayload> query) : base(query)
        {
        }

        public CatalogDeletePayloadQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public CatalogDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogUserErrorQueryBuilder> build)
        {
            var query = new Query<CatalogUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CatalogUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CatalogUserError>(query);
            return this;
        }
    }
}